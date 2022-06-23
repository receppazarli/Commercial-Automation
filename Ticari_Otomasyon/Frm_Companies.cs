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
    public partial class Frm_Companies : Form
    {
        public Frm_Companies()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();

        void List() // İşlem yaptığımda yada girili olan veriyi çağırmak için methodum
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Companies", connection.Connection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Customers.DataSource = dataTable;
        }

        void CityList()// Şehirleri çağıran method
        {
            SqlCommand command = new SqlCommand("Select City from Cities", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbbox_City.Properties.Items.Add(sqlDataReader[0]);
            }
            connection.Connection().Close();
        }

        void Clean() // Sistem açıldığında yan taraftaki giriş yerlerini temiz vermesi için yapılmış method.
        {
            txt_Id.Text = "";
            txt_CompanyName.Text = "";
            txt_ContactTitle.Text = "";
            txt_ContactFirstAndLastName.Text = "";
            msktxb_ContactIdentityNumber.Text = "";
            txt_Sector.Text = "";
            msktxbx_Phone1.Text = "";
            msktxbx_Phone2.Text = "";
            msktxbx_Phone3.Text = "";
            txedit_Mail.Text = "";
            msktxbx_Fax.Text = "";
            cmbbox_City.Text = "";
            cmbbox_Country.Text = "";
            txtedit_Address.Text = "";
            txtedit_TaxAuthority.Text = "";
            txtedit_SpecialCode1.Text = "";
            txtedit_SpecialCode2.Text = "";
            txtedit_SpecialCode3.Text = "";

        }

        //void CariCodeInfo()// Cari kodu açıklamayı çağırmak için method.
        //{
        //    SqlCommand command = new SqlCommand("Select CompanyCode1 from SpecialCodes", connection.Connection());
        //    SqlDataReader sqlDataReader = command.ExecuteReader();
        //    while (sqlDataReader.Read())
        //    {
        //        richtxbx_Code1.Text = sqlDataReader[0].ToString();
        //    }
        //    connection.Connection().Close();
        //}


        void CariCodeInfo()
        {
            SqlCommand sqlCommand = new SqlCommand("Select CompanyCode1 from SpecialCodes", connection.Connection());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                richtxbx_Code1.Text = sqlDataReader[0].ToString();
            }
            connection.Connection().Close();
        }


        private void Frm_Companies_Load(object sender, EventArgs e)
        {

            List();
            CityList();
            Clean();
            CariCodeInfo();


        }

        private void cmbbox_City_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbbox_Country.Properties.Items.Clear();
            SqlCommand command =
                new SqlCommand("Select Country from Countries where City=@p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", cmbbox_City.SelectedIndex + 1);// +1 ekledik çünkü ilçeleri almaya 0 dan başlıyor yani ben 34 plakalıyı seçiyorum mesela o 35 i alıyor.
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbbox_Country.Properties.Items.Add(sqlDataReader[0]);
            }
            connection.Connection().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                txt_Id.Text = dataRow["Id"].ToString();
                txt_CompanyName.Text = dataRow["CompanyName"].ToString();
                txt_ContactTitle.Text = dataRow["ContactTitle"].ToString();
                txt_ContactFirstAndLastName.Text = dataRow["ContactFirstAndLastName"].ToString();
                msktxb_ContactIdentityNumber.Text = dataRow["ContactIdentityNumber"].ToString();
                txt_Sector.Text = dataRow["Sector"].ToString();
                msktxbx_Phone1.Text = dataRow["Phone1"].ToString();
                msktxbx_Phone2.Text = dataRow["Phone2"].ToString();
                msktxbx_Phone3.Text = dataRow["Phone3"].ToString();
                txedit_Mail.Text = dataRow["Mail"].ToString();
                msktxbx_Fax.Text = dataRow["Fax"].ToString();
                cmbbox_City.Text = dataRow["City"].ToString();
                cmbbox_Country.Text = dataRow["Country"].ToString();
                txtedit_Address.Text = dataRow["Address"].ToString();
                txtedit_TaxAuthority.Text = dataRow["TaxAuthority"].ToString();
                richtxbx_Code1.Text = dataRow["SpecialCode1"].ToString();
                richtxbx_Code2.Text = dataRow["SpecialCode2"].ToString();
                richtxbx_Code3.Text = dataRow["SpecialCode3"].ToString();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "insert into Companies (CompanyName,ContactTitle,ContactFirstAndLastName,ContactIdentityNumber,Sector,Phone1,Phone2,Phone3,Mail,Fax,City,Country,Address,TaxAuthority," +
                "SpecialCode1,SpecialCode2,SpecialCode3) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)",
                connection.Connection());

            command.Parameters.AddWithValue("@p1", txt_CompanyName.Text);
            command.Parameters.AddWithValue("@p2", txt_ContactTitle.Text);
            command.Parameters.AddWithValue("@p3", txt_ContactFirstAndLastName.Text);
            command.Parameters.AddWithValue("@p4", msktxb_ContactIdentityNumber.Text);
            command.Parameters.AddWithValue("@p5", txt_Sector.Text);
            command.Parameters.AddWithValue("@p6", msktxbx_Phone1.Text);
            command.Parameters.AddWithValue("@p7", msktxbx_Phone2.Text);
            command.Parameters.AddWithValue("@p8", msktxbx_Phone3.Text);
            command.Parameters.AddWithValue("@p9", txedit_Mail.Text);
            command.Parameters.AddWithValue("@p10", msktxbx_Fax.Text);
            command.Parameters.AddWithValue("@p11", cmbbox_City.Text);
            command.Parameters.AddWithValue("@p12", cmbbox_Country.Text);
            command.Parameters.AddWithValue("@p13", txtedit_Address.Text);
            command.Parameters.AddWithValue("@p14", txtedit_TaxAuthority.Text);
            command.Parameters.AddWithValue("@p15", txtedit_SpecialCode1.Text);
            command.Parameters.AddWithValue("@p16", txtedit_SpecialCode2.Text);
            command.Parameters.AddWithValue("@p17", txtedit_SpecialCode3.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Firma Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Companies where Id=@p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Firma silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();
            Clean();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "Update Companies set CompanyName=@p1,ContactTitle=@p2,ContactFirstAndLastName=@p3,ContactIdentityNumber=@p4,Sector=@p5,Phone1=@p6,Phone2=@p7,Phone3=@p8," +
                "Mail=@p9,Fax=@p10,City=@p11,Country=@p12,Address=@p13,TaxAuthority=@p14,SpecialCode1=@p15,SpecialCode2=@p16,SpecialCode3=@p17 where Id=@p18 ",
                connection.Connection());

            command.Parameters.AddWithValue("@p1", txt_CompanyName.Text);
            command.Parameters.AddWithValue("@p2", txt_ContactTitle.Text);
            command.Parameters.AddWithValue("@p3", txt_ContactFirstAndLastName.Text);
            command.Parameters.AddWithValue("@p4", msktxb_ContactIdentityNumber.Text);
            command.Parameters.AddWithValue("@p5", txt_Sector.Text);
            command.Parameters.AddWithValue("@p6", msktxbx_Phone1.Text);
            command.Parameters.AddWithValue("@p7", msktxbx_Phone2.Text);
            command.Parameters.AddWithValue("@p8", msktxbx_Phone3.Text);
            command.Parameters.AddWithValue("@p9", txedit_Mail.Text);
            command.Parameters.AddWithValue("@p10", msktxbx_Fax.Text);
            command.Parameters.AddWithValue("@p11", cmbbox_City.Text);
            command.Parameters.AddWithValue("@p12", cmbbox_Country.Text);
            command.Parameters.AddWithValue("@p13", txtedit_Address.Text);
            command.Parameters.AddWithValue("@p14", txtedit_TaxAuthority.Text);
            command.Parameters.AddWithValue("@p15", txtedit_SpecialCode1.Text);
            command.Parameters.AddWithValue("@p16", txtedit_SpecialCode2.Text);
            command.Parameters.AddWithValue("@p17", txtedit_SpecialCode3.Text);
            command.Parameters.AddWithValue("@p18", txt_Id.Text);

            //SqlCommand command = new SqlCommand(
            //        "Update Companies set CompanyName=@CompanyName,ContactTitle=@ContactTitle,ContactFirstAndLastName=@ContactFirstAndLastName,ContactIdentityNumber=@ContactIdentityNumber,Sector=@Sector,Phone1=@Phone1,Phone2=@Phone2,Phone3=@Phone3" +
            //        "Mail=@Mail,Fax=@Fax,City=@City,Country=@Country,Address=@Address,TaxAuthority=@TaxAuthority,SpecialCode1=@SpecialCode1,SpecialCode2=@SpecialCode2,SpecialCode3=@SpecialCode3 where Id=@Id ",
            //        connection.Connection());
            //command.Parameters.AddWithValue("@Companies", txt_CompanyName.Text);
            //command.Parameters.AddWithValue("@Companies", txt_CompanyName.Text);
            //command.Parameters.AddWithValue("@Companies", txt_CompanyName.Text);
            //command.Parameters.AddWithValue("@Companies", txt_CompanyName.Text);
            //command.Parameters.AddWithValue("@Companies", txt_CompanyName.Text);
            //command.Parameters.AddWithValue("@Companies", txt_CompanyName.Text);
            //command.Parameters.AddWithValue("@Companies", txt_CompanyName.Text);
            //command.Parameters.AddWithValue("@Companies", txt_CompanyName.Text);

            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Firma güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
            Clean();


        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}
