using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Frm_Settings : Form
    {
        public Frm_Settings()
        {
            InitializeComponent();
        } 


        private Sql_Connection connection = new Sql_Connection();
        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Admin", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Setting.DataSource = dataTable;
        }
        private void Frm_Settings_Load(object sender, EventArgs e)
        {
            List();
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Admin values (@p1,@p2)", connection.Connection());
            command.Parameters.AddWithValue("@p1", txtUserName.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Yeni admin siteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                txtUserName.Text = dataRow["UserName"].ToString();
                txtPassword.Text = dataRow["Password"].ToString();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Admin set Password=@Password where UserName=@UserName",
                connection.Connection());

            command.Parameters.AddWithValue("Password", txtPassword.Text);
            command.Parameters.AddWithValue("@UserName", txtUserName.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Şifreniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
        }
    }
}
