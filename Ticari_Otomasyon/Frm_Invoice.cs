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
    public partial class Frm_Invoice : Form
    {
        public Frm_Invoice()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();


        void List()
        {
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("Select * from InvoiceInformation", connection.Connection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Invoice.DataSource = dataTable;
        }

        void EmployeesList()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("Select Id, FirstName+'&'+LastName as [Name&Surname] from Personnels",
                    connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            //Lookup_Employees.Properties.NullText = "Lütfen bir personel seçiniz.";
            Lookup_Employees.Properties.ValueMember = "Id";
            Lookup_Employees.Properties.DisplayMember = "Name&Surname";
            Lookup_Employees.Properties.DataSource = dataTable;
        }

        void ProductIdList()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("Select Id,ProductName from Products",
                    connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            //Lookup_Employees.Properties.NullText = "Lütfen bir personel seçiniz.";
            lookup_InvoiceProductId.Properties.ValueMember = "ProductName";
            lookup_InvoiceProductId.Properties.DisplayMember = "Id";
            lookup_InvoiceProductId.Properties.DataSource = dataTable;
        }

        void CompanyList()
        {
            lookup_Cari.Text = "";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Id,CompanyName from Companies", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            lookup_Cari.Properties.ValueMember = "Id";
            lookup_Cari.Properties.DisplayMember = "CompanyName";
            lookup_Cari.Properties.DataSource = dataTable;
        }

        void CustomerList()
        {

            lookup_Cari.Text = "";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Id,FirstName+'&'+LastName as [Name&Surname] from Customers", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            lookup_Cari.Properties.ValueMember = "Id";
            lookup_Cari.Properties.DisplayMember = "Name&Surname";
            lookup_Cari.Properties.DataSource = dataTable;
        }


        void Clean()
        {
            txt_Id.Text = "";
            txt_Serial.Text = "";
            txt_RankNo.Text = "";
            msktxb_Date.Text = "";
            msktxt_Clock.Text = "";
            txt_TaxAuthority.Text = "";
            txt_Buyer.Text = "";
            txt_TeslimEden.Text = "";
            txt_TeslimAlan.Text = "";
        }
        private void Frm_Invoice_Load(object sender, EventArgs e)
        {
            List();
            Clean();
            EmployeesList();
            ProductIdList();
          
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            // Firma Cari
            if (txt_InvoiceId.Text == "" && cmbbx_CariTür.Text == "Company")
            {
                
                double miktar, fiyat, tutar;
                fiyat = Convert.ToDouble(txt_Price.Text);
                miktar = Convert.ToDouble(txt_Miktar.Text);
                tutar = miktar * fiyat;
                txt_Tutar.Text = tutar.ToString();

                SqlCommand command = new SqlCommand(
                    "insert into InvoiceDetail (ProductName,Miktar,Price,Tutar,InvoiceId) values" +
                    "(@ProductName,@Miktar,@Price,@Tutar,@InvoiceId)", connection.Connection());
                command.Parameters.AddWithValue("@ProductName", txt_ProductName.Text);
                command.Parameters.AddWithValue("@Miktar", txt_Miktar.Text);
                command.Parameters.AddWithValue("@Price", decimal.Parse(txt_Price.Text));
                command.Parameters.AddWithValue("@Tutar", decimal.Parse(txt_Tutar.Text));
                command.Parameters.AddWithValue("@InvoiceId", txt_InvoiceId.Text);
                command.ExecuteReader();
                connection.Connection().Close();


                // Haraket tablosuna veri girişi için
                SqlCommand commandmotion = new SqlCommand(
                    "insert into CompanyMotions (ProductId,Piece,Personnel,CompanyId,Price,Total,InvoiceId,Date) values " +
                    "(@ProductId,@Piece,@Personnel,@CompanyId,@Price,@Total,@InvoiceId,@Date)",
                    connection.Connection());
                commandmotion.Parameters.AddWithValue("@ProductId", decimal.Parse(lookup_InvoiceProductId.Text));
                commandmotion.Parameters.AddWithValue("@Piece", txt_Miktar.Text);
                commandmotion.Parameters.AddWithValue("@Personnel", Lookup_Employees.EditValue);
                commandmotion.Parameters.AddWithValue("@CompanyId", lookup_Cari.EditValue);
                commandmotion.Parameters.AddWithValue("@Price", decimal.Parse(txt_Price.Text));
                commandmotion.Parameters.AddWithValue("@Total", decimal.Parse(txt_Tutar.Text));
                commandmotion.Parameters.AddWithValue("@InvoiceId", txt_InvoiceId.Text);
                commandmotion.Parameters.AddWithValue("@Date", msktxb_Date.Text);
               
                commandmotion.ExecuteNonQuery();
                connection.Connection();

                //Stok sayısını azaltma 
                SqlCommand commandstock =
                    new SqlCommand("update Products set Stock=Stock-@Miktar where Id=@Id", connection.Connection());

                commandstock.Parameters.AddWithValue("@Miktar", txt_Miktar.Text);
                commandstock.Parameters.AddWithValue("@Id", decimal.Parse(lookup_InvoiceProductId.Text));
                CompanyList();
                connection.Connection().Close();

                MessageBox.Show("Fatura ait ürün sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }

            // Müşteri Cari
            else 
            {
                
                double miktar, fiyat, tutar;
                fiyat = Convert.ToDouble(txt_Price.Text);
                miktar = Convert.ToDouble(txt_Miktar.Text);
                tutar = miktar * fiyat;
                txt_Tutar.Text = tutar.ToString();

                SqlCommand command = new SqlCommand(
                    "insert into InvoiceDetail (ProductName,Miktar,Price,Tutar,InvoiceId) values" +
                    "(@ProductName,@Miktar,@Price,@Tutar,@InvoiceId)", connection.Connection());
                command.Parameters.AddWithValue("@ProductName", txt_ProductName.Text);
                command.Parameters.AddWithValue("@Miktar", txt_Miktar.Text);
                command.Parameters.AddWithValue("@Price", decimal.Parse(txt_Price.Text));
                command.Parameters.AddWithValue("@Tutar", decimal.Parse(txt_Tutar.Text));
                command.Parameters.AddWithValue("@InvoiceId", txt_InvoiceId.Text);
                command.ExecuteReader();
                connection.Connection().Close();

                // Haraket tablosuna veri girişi için
                SqlCommand commandmotion = new SqlCommand(
                    "insert into CustomerMotions (ProductId,Piece,Personnel,CustomerId,Price,Total,InvoiceId,Date) values " +
                    "(@ProductId,@Piece,@Personnel,@CustomerId,@Price,@Total,@InvoiceId,@Date)",
                    connection.Connection());
                commandmotion.Parameters.AddWithValue("@ProductId", decimal.Parse(lookup_InvoiceProductId.Text));
                commandmotion.Parameters.AddWithValue("@Piece", txt_Miktar.Text);
                commandmotion.Parameters.AddWithValue("@Personnel", Lookup_Employees.EditValue);
                commandmotion.Parameters.AddWithValue("@CustomerId", lookup_Cari.EditValue);
                commandmotion.Parameters.AddWithValue("@Price", decimal.Parse(txt_Price.Text));
                commandmotion.Parameters.AddWithValue("@Total", decimal.Parse(txt_Tutar.Text));
                commandmotion.Parameters.AddWithValue("@InvoiceId", txt_InvoiceId.Text);
                commandmotion.Parameters.AddWithValue("@Date", msktxb_Date.Text);
                commandmotion.ExecuteNonQuery();
                connection.Connection();

                //Stok sayısını azaltma 
                SqlCommand commandstock =
                    new SqlCommand("update Products set Stock=Stock-@Miktar where Id=@Id", connection.Connection());

                commandstock.Parameters.AddWithValue("@Miktar", txt_Miktar.Text);
                commandstock.Parameters.AddWithValue("@Id", decimal.Parse(lookup_InvoiceProductId.Text));
                CustomerList();
                connection.Connection().Close();

                MessageBox.Show("Fatura ait ürün sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "insert into InvoiceInformation (Serial,RankNo,Date,Clock,TaxAuthority,Buyer,TeslimEden,TeslimAlan) values" +
                "(@Serial,@RankNo,@Date,@Clock,@TaxAuthority,@Buyer,@TeslimEden,@TeslimAlan)", connection.Connection());

            command.Parameters.AddWithValue("@Serial", txt_Serial.Text);
            command.Parameters.AddWithValue("@RankNo", txt_RankNo.Text);
            command.Parameters.AddWithValue("@Date", msktxb_Date.Text);
            command.Parameters.AddWithValue("@Clock", msktxt_Clock.Text);
            command.Parameters.AddWithValue("@TaxAuthority", txt_TaxAuthority.Text);
            command.Parameters.AddWithValue("@Buyer", txt_Buyer.Text);
            command.Parameters.AddWithValue("@TeslimEden", txt_TeslimEden.Text);
            command.Parameters.AddWithValue("@TeslimAlan", txt_TeslimAlan.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Fatura bilgileri sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            List();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                txt_Id.Text = dataRow["InvoiceInfoId"].ToString();
                txt_Serial.Text = dataRow["Serial"].ToString();
                txt_RankNo.Text = dataRow["RankNo"].ToString();
                msktxb_Date.Text = dataRow["Date"].ToString();
                msktxt_Clock.Text = dataRow["Clock"].ToString();
                txt_TaxAuthority.Text = dataRow["TaxAuthority"].ToString();
                txt_Buyer.Text = dataRow["Buyer"].ToString();
                txt_TeslimEden.Text = dataRow["TeslimEden"].ToString();
                txt_TeslimAlan.Text = dataRow["TeslimAlan"].ToString();


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Clean();
        }



        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from InvoiceInformation where InvoiceInfoId=@InvoiceInfoId",
                connection.Connection());
            command.Parameters.AddWithValue("@InvoiceInfoId", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Fatura silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand command =
                new SqlCommand(
                    "update InvoiceInformation set Serial=@Serial,RankNo=@RankNo,Date=@Date,Clock=@Clock,TaxAuthority=@TaxAuthority,Buyer=@Buyer,TeslimEden=@TeslimEden,TeslimAlan=@TeslimAlan where InvoiceInfoId=@InvoiceInfoId",
                    connection.Connection());

            command.Parameters.AddWithValue("@Serial", txt_Serial.Text);
            command.Parameters.AddWithValue("@RankNo", txt_RankNo.Text);
            command.Parameters.AddWithValue("@Date", msktxb_Date.Text);
            command.Parameters.AddWithValue("@Clock", msktxt_Clock.Text);
            command.Parameters.AddWithValue("@TaxAuthority", txt_TaxAuthority.Text);
            command.Parameters.AddWithValue("@Buyer", txt_Buyer.Text);
            command.Parameters.AddWithValue("@TeslimEden", txt_TeslimEden.Text);
            command.Parameters.AddWithValue("@TeslimAlan", txt_TeslimAlan.Text);
            command.Parameters.AddWithValue("@InvoiceInfoId", txt_Id.Text);

            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Fatura bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            List();

        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_InvoiceProducts frmInvoiceProducts = new Frm_InvoiceProducts();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                frmInvoiceProducts.Id = dataRow["InvoiceInfoId"].ToString();

            }
            frmInvoiceProducts.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select ProductName,SalePrice from Products where Id=@Id",
                connection.Connection());
            command.Parameters.AddWithValue("@Id", lookup_InvoiceProductId.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txt_ProductName.Text = sqlDataReader[0].ToString();
                txt_Price.Text = sqlDataReader[1].ToString();

            }
        }


        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (cmbbx_CariTür.Text == "Company")
            {
                CompanyList();
            }
            else 
            {
                CustomerList();
            }
        }
    }

}


