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
    public partial class Frm_Personnels : Form
    {
        public Frm_Personnels()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();

        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Personnels", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Personnel.DataSource = dataTable;
        }

        void CityList() // Şehirleri çağıran method
        {
            SqlCommand command = new SqlCommand("Select City from Cities", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbbx_City.Properties.Items.Add(sqlDataReader[0]);
            }

            connection.Connection().Close();
        }

        private void cmbbx_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbx_Country.Properties.Items.Clear();
            SqlCommand command =
                new SqlCommand("Select Country from Countries where City=@p1", connection.Connection());
            command.Parameters.AddWithValue("@p1",
                cmbbx_City.SelectedIndex +
                1); // +1 ekledik çünkü ilçeleri almaya 0 dan başlıyor yani ben 34 plakalıyı seçiyorum mesela o 35 i alıyor.
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbbx_Country.Properties.Items.Add(sqlDataReader[0]);
            }

            connection.Connection().Close();
        }

        void Clean()
        {
            txt_Id.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            msktxb_Phone.Text = "";
            msktxb_IdentityNumber.Text = "";
            txt_Mail.Text = "";
            cmbbx_City.Text = "";
            cmbbx_Country.Text = "";
            txtedit_Address.Text = "";
            txtedit_Task.Text = "";
        }

        private void Frm_Personnels_Load(object sender, EventArgs e)
        {
            List();
            CityList();
            Clean();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "insert into  Personnels (FirstName,LastName,Phone,IdentityNumber,Mail,City,Country,Address,Task) values " +
                "(@FirstName,@LastName,@Phone,@IdentityNumber,@Mail,@City,@Country,@Address,@Task)",
                connection.Connection());

            command.Parameters.AddWithValue("@FirstName", txt_FirstName.Text);
            command.Parameters.AddWithValue("@LastName", txt_LastName.Text);
            command.Parameters.AddWithValue("@Phone", msktxb_Phone.Text);
            command.Parameters.AddWithValue("@IdentityNumber", msktxb_IdentityNumber.Text);
            command.Parameters.AddWithValue("@Mail", txt_Mail.Text);
            command.Parameters.AddWithValue("@City", cmbbx_City.Text);
            command.Parameters.AddWithValue("@Country", cmbbx_Country.Text);
            command.Parameters.AddWithValue("@Address", txtedit_Address.Text);
            command.Parameters.AddWithValue("@Task", txtedit_Task.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Personel kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();
        }

        private void gridView1_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                txt_Id.Text = dataRow["Id"].ToString();
                txt_FirstName.Text = dataRow["FirstName"].ToString();
                txt_LastName.Text = dataRow["LastName"].ToString();
                msktxb_Phone.Text = dataRow["Phone"].ToString();
                msktxb_IdentityNumber.Text = dataRow["IdentityNumber"].ToString();
                txt_Mail.Text = dataRow["Mail"].ToString();
                cmbbx_City.Text = dataRow["City"].ToString();
                cmbbx_Country.Text = dataRow["Country"].ToString();
                txtedit_Address.Text = dataRow["Address"].ToString();
                txtedit_Task.Text = dataRow["Task"].ToString();

            }
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Personnels where Id=@Id", connection.Connection());
            command.Parameters.AddWithValue("@Id", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Personel silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            List();
            Clean();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command =
                new SqlCommand(
                    "Update Personnels set  FirstName=@FirstName,LastName=@LastName,Phone=@Phone,IdentityNumber=@IdentityNumber,Mail=@Mail,City=@City,Country=@Country,Address=@Address,Task=@Task where Id=@Id",
                    connection.Connection());

            command.Parameters.AddWithValue("@FirstName", txt_FirstName.Text);
            command.Parameters.AddWithValue("@LastName", txt_LastName.Text);
            command.Parameters.AddWithValue("@Phone", msktxb_Phone.Text);
            command.Parameters.AddWithValue("@IdentityNumber", msktxb_IdentityNumber.Text);
            command.Parameters.AddWithValue("@Mail", txt_Mail.Text);
            command.Parameters.AddWithValue("@City", cmbbx_City.Text);
            command.Parameters.AddWithValue("@Country", cmbbx_Country.Text);
            command.Parameters.AddWithValue("@Address", txtedit_Address.Text);
            command.Parameters.AddWithValue("@Task", txtedit_Task.Text);
            command.Parameters.AddWithValue("@Id", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Personel güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
            Clean();

        }
    }
}
