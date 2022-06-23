using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ticari_Otomasyon
{
    public partial class Frm_Customers : Form
    {
        public Frm_Customers()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();
        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Customers ", connection.Connection());
            sqlDataAdapter.Fill(dataTable);   // dataadapterın içini data tableyla doldur
            Grdcntrl_Customers.DataSource = dataTable;

        }

        void CityList()
        {
            SqlCommand command = new SqlCommand("Select City from Cities", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbbx_City.Properties.Items.Add(sqlDataReader[0]);
            }
            connection.Connection().Close();
        }

        void Clean()
        {
            txt_Id.Text = "";
            txtedit_Address.Text = "";
            txtedit_TaxAuthority.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Mail.Text = "";
            msktxb_Phone.Text = "";
            msktxb_Phone2.Text = "";
            msktxb_IdentityNumber.Text = "";
            cmbbx_City.Text = "";
            cmbbx_Country.Text = "";
        }

        private void Frm_Customers_Load(object sender, EventArgs e)
        {
            List();
            CityList();
            Clean();
        }

        private void cmbbx_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbx_Country.Properties.Items.Clear();
            SqlCommand command =
                new SqlCommand("Select Country from Countries where City=@p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", cmbbx_City.SelectedIndex + 1);// +1 ekledik çünkü ilçeleri almaya 0 dan başlıyor yani ben 34 plakalıyı seçiyorum mesela o 35 i alıyor.
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbbx_Country.Properties.Items.Add(sqlDataReader[0]);
            }
            connection.Connection().Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Customers(FirstName,LastName,Phone,Phone2,IdentityNumber,Mail,City,County,Address,TaxAuthority) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",
                connection.Connection());

            command.Parameters.AddWithValue("@p1", txt_FirstName.Text);
            command.Parameters.AddWithValue("@p2", txt_LastName.Text);
            command.Parameters.AddWithValue("@p3", msktxb_Phone.Text);
            command.Parameters.AddWithValue("@p4", msktxb_Phone2.Text);
            command.Parameters.AddWithValue("@p5", msktxb_IdentityNumber.Text);
            command.Parameters.AddWithValue("@p6", txt_Mail.Text);
            command.Parameters.AddWithValue("@p7", cmbbx_City.Text);
            command.Parameters.AddWithValue("@p8", cmbbx_Country.Text);
            command.Parameters.AddWithValue("@p9", txtedit_Address.Text);
            command.Parameters.AddWithValue("@p10", txtedit_TaxAuthority.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Müşteri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();

        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {

            //SqlCommand command = new SqlCommand("Delete from Customers where Id=@p1", connection.Connection());
            //command.Parameters.AddWithValue("@p1", txt_Id.Text);
            //command.ExecuteNonQuery();
            //connection.Connection().Close();

            DialogResult result;
            result = MessageBox.Show("İşlemi onaylıyor musunuz?", "Onay pençeresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("Delete from Customers where Id=@p1", connection.Connection());
                command.Parameters.AddWithValue("@p1", txt_Id.Text);
                command.ExecuteNonQuery();
                connection.Connection().Close();
                MessageBox.Show("Müşteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                List();
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                txt_Id.Text = dataRow["Id"].ToString();
                txt_FirstName.Text = dataRow["FirstName"].ToString();
                txt_LastName.Text = dataRow["LastName"].ToString();
                msktxb_Phone.Text = dataRow["Phone"].ToString();
                msktxb_Phone2.Text = dataRow["Phone2"].ToString();
                msktxb_IdentityNumber.Text = dataRow["IdentityNumber"].ToString();
                txt_Mail.Text = dataRow["Mail"].ToString();
                cmbbx_City.Text = dataRow["City"].ToString();
                cmbbx_Country.Text = dataRow["County"].ToString();
                txtedit_Address.Text = dataRow["Address"].ToString();
                txtedit_TaxAuthority.Text = dataRow["TaxAuthority"].ToString();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command =
                new SqlCommand(
                    "Update Customers set FirstName=@p1,LastName=@p2,Phone=@p3,Phone2=@p4,IdentityNumber=@p5,Mail=@p6,City=@p7,County=@p8,Address=@p9,TaxAuthority=@p10 where Id=@p11",
                    connection.Connection());

            command.Parameters.AddWithValue("@p1", txt_FirstName.Text);
            command.Parameters.AddWithValue("@p2", txt_LastName.Text);
            command.Parameters.AddWithValue("@p3", msktxb_Phone.Text);
            command.Parameters.AddWithValue("@p4", msktxb_Phone2.Text);
            command.Parameters.AddWithValue("@p5", msktxb_IdentityNumber.Text);
            command.Parameters.AddWithValue("@p6", txt_Mail.Text);
            command.Parameters.AddWithValue("@p7", cmbbx_City.Text);
            command.Parameters.AddWithValue("@p8", cmbbx_Country.Text);
            command.Parameters.AddWithValue("@p9", txtedit_Address.Text);
            command.Parameters.AddWithValue("@p10", txtedit_TaxAuthority.Text);
            command.Parameters.AddWithValue("@p11", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection();
            MessageBox.Show("Müşteri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
            Clean();
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
