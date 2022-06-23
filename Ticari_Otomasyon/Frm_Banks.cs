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
    public partial class Frm_Banks : Form
    {
        public Frm_Banks()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();
        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Execute BankInformation", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Banks.DataSource = dataTable;
        }

        void CityList()// Şehirleri çağıran method
        {
            SqlCommand command = new SqlCommand("Select City from Cities", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cmbbx_City.Properties.Items.Add(sqlDataReader[0]);
            }
            connection.Connection().Close();
        }

        void CompanyList()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Id,CompanyName from Companies", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Lookup_Compay.Properties.ValueMember = "Id";
            Lookup_Compay.Properties.DisplayMember = "CompanyName";
            Lookup_Compay.Properties.DataSource = dataTable;
        }

        void Clean()
        {
            txt_Id.Text = "";
            txt_AccountType.Text = "";
            txt_BankName.Text = "";
            txt_BranchOffice.Text = "";
            msktxb_Phone.Text = "";
            msktxb_AcountNo.Text = "";
            msktxb_Authorized.Text = "";
            msktxb_Date.Text = "";
            msktxb_Iban.Text = "";
            cmbbx_City.Text = "";
            cmbbx_Country.Text = "";
            Lookup_Compay.Text = "";
        }


        private void Frm_Banks_Load(object sender, EventArgs e)
        {
            List();
            CityList();
            CompanyList();
            Clean();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "insert into Banks (BankName,City,Country,BranchOffice,Iban,AcountNo,Authorized,Phone,Date,AccountType,CompanyId) values" +
                "(@BankName,@City,@Country,@BranchOffice,@Iban,@AcountNo,@Authorized,@Phone,@Date,@AccountType,@CompanyId)",
                connection.Connection());

            command.Parameters.AddWithValue("@BankName", txt_BankName.Text);
            command.Parameters.AddWithValue("@City", cmbbx_City.Text);
            command.Parameters.AddWithValue("@Country", cmbbx_Country.Text);
            command.Parameters.AddWithValue("@BranchOffice", txt_BranchOffice.Text);
            command.Parameters.AddWithValue("@Iban", msktxb_Iban.Text);
            command.Parameters.AddWithValue("@AcountNo", txt_AccountType.Text);
            command.Parameters.AddWithValue("@Authorized", msktxb_Authorized.Text);
            command.Parameters.AddWithValue("@Phone", msktxb_Phone.Text);
            command.Parameters.AddWithValue("@Date", msktxb_Date.Text);
            command.Parameters.AddWithValue("@AccountType", txt_AccountType.Text);
            command.Parameters.AddWithValue("@CompanyId", Lookup_Compay.EditValue);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Banka bilgisi kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();

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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                txt_Id.Text = dataRow["Id"].ToString();
                txt_BankName.Text = dataRow["BankName"].ToString();
                cmbbx_City.Text = dataRow["City"].ToString();
                cmbbx_Country.Text = dataRow["Country"].ToString();
                txt_BranchOffice.Text = dataRow["BranchOffice"].ToString();
                msktxb_Iban.Text = dataRow["Iban"].ToString();
                msktxb_AcountNo.Text = dataRow["AcountNo"].ToString();
                msktxb_Authorized.Text = dataRow["Authorized"].ToString();
                msktxb_Phone.Text = dataRow["Phone"].ToString();
                msktxb_Date.Text = dataRow["Date"].ToString();
                txt_AccountType.Text = dataRow["AccountType"].ToString();
                //Lookup_Compay.Text = dataRow["CompanyId"].ToString();

            }
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Banks where Id=@Id",connection.Connection());
            command.Parameters.AddWithValue("@Id", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Banka bilgisi silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
            Clean();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "update Banks set BankName=@BankName,City=@City,Country=@Country,BranchOffice=@BranchOffice,Iban=@Iban,AcountNo=@AcountNo,Authorized=@Authorized,Phone=@Phone" +
                ",Date=@Date,AccountType=@AccountType,CompanyId=@CompanyId where Id=@Id", connection.Connection());

            command.Parameters.AddWithValue("@BankName", txt_BankName.Text);
            command.Parameters.AddWithValue("@City", cmbbx_City.Text);
            command.Parameters.AddWithValue("@Country", cmbbx_Country.Text);
            command.Parameters.AddWithValue("@BranchOffice", txt_BranchOffice.Text);
            command.Parameters.AddWithValue("@Iban", msktxb_Iban.Text);
            command.Parameters.AddWithValue("@AcountNo", msktxb_AcountNo.Text);
            command.Parameters.AddWithValue("@Authorized", msktxb_Authorized.Text);
            command.Parameters.AddWithValue("@Phone", msktxb_Phone.Text);
            command.Parameters.AddWithValue("@Date", msktxb_Date.Text);
            command.Parameters.AddWithValue("@AccountType", txt_AccountType.Text);
            command.Parameters.AddWithValue("@CompanyId", Lookup_Compay.EditValue);
            command.Parameters.AddWithValue("@Id", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Banka bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();


        }

        //private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

        //    if (dataRow != null)
        //    {
        //        txt_Id.Text = dataRow["Id"].ToString();
        //        txt_BankName.Text = dataRow["BankName"].ToString();
        //        cmbbx_City.Text = dataRow["City"].ToString();
        //        cmbbx_Country.Text = dataRow["Country"].ToString();
        //        txt_BranchOffice.Text = dataRow["BranchOffice"].ToString();
        //        msktxb_Iban.Text = dataRow["Iban"].ToString();
        //        msktxb_AcountNo.Text = dataRow["AcountNo"].ToString();
        //        msktxb_Authorized.Text = dataRow["Authorized"].ToString();
        //        msktxb_Phone.Text = dataRow["Phone"].ToString();
        //        msktxb_Date.Text = dataRow["Date"].ToString();
        //        txt_AccountType.Text = dataRow["AccountType"].ToString();
        //        //Lookup_Compay.Text = dataRow["CompanyId"].ToString();

        //    }

        //}


    }
}
