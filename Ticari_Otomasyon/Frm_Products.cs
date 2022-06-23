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
    public partial class Frm_Products : Form
    {
        public Frm_Products()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();

         void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Products ", connection.Connection());
            sqlDataAdapter.Fill(dataTable);   // dataadapterın içini data tableyla doldur
            gridControl1.DataSource = dataTable;

        }

         void Clean()
         {
             txt_Id.Text = "";
             txt_ProductName.Text = "";
             txt_SupplierCompany.Text = "";
             txt_Model.Text = "";
             txt_PurchasePrice.Text = "";
             txt_SalePrice.Text = "";
             mskdtxt_Year.Text = "";
             nmrcUD_Stock.Value = 0;
             richtxt_Details.Text = "";
         }

        private void Frm_Products_Load(object sender, EventArgs e)
        {
            List();
            Clean();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Verileri kaydetme

            SqlCommand command =
                new SqlCommand(
                    "insert into Products (ProductName,SupplierCompany,Model,Year,Stock,PurchasePrice,SalePrice,Details) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection.Connection());
            command.Parameters.AddWithValue("@p1", txt_ProductName.Text);
            command.Parameters.AddWithValue("@p2", txt_SupplierCompany.Text);
            command.Parameters.AddWithValue("@p3", txt_Model.Text);
            command.Parameters.AddWithValue("@p4", mskdtxt_Year.Text);
            command.Parameters.AddWithValue("@p5", int.Parse(nmrcUD_Stock.Value.ToString()));
            command.Parameters.AddWithValue("@p6", decimal.Parse(txt_PurchasePrice.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(txt_SalePrice.Text));
            command.Parameters.AddWithValue("@p8", richtxt_Details.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand commanddelete = new SqlCommand("Delete from Products where Id=@p1", connection.Connection());
            commanddelete.Parameters.AddWithValue("@p1", txt_Id.Text);
            commanddelete.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txt_Id.Text = dataRow["Id"].ToString();
            txt_ProductName.Text = dataRow["ProductName"].ToString();
            txt_SupplierCompany.Text = dataRow["SupplierCompany"].ToString();
            txt_Model.Text = dataRow["Model"].ToString();
            mskdtxt_Year.Text = dataRow["Year"].ToString();
            nmrcUD_Stock.Value = decimal.Parse(dataRow["Stock"].ToString());
            txt_PurchasePrice.Text = dataRow["PurchasePrice"].ToString();
            txt_SalePrice.Text = dataRow["SalePrice"].ToString();
            richtxt_Details.Text = dataRow["Details"].ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand commandupdate =
                new SqlCommand(
                    "update Products set ProductName=@P1,SupplierCompany=@P2,Model=@P3,Year=@P4,Stock=@P5,PurchasePrice=@P6,SalePrice=@P7,Details=@P8 where Id=@P9",connection.Connection());
            commandupdate.Parameters.AddWithValue("@p1", txt_ProductName.Text);
            commandupdate.Parameters.AddWithValue("@p2", txt_SupplierCompany.Text);
            commandupdate.Parameters.AddWithValue("@p3", txt_Model.Text);
            commandupdate.Parameters.AddWithValue("@p4", mskdtxt_Year.Text);
            commandupdate.Parameters.AddWithValue("@p5", int.Parse(nmrcUD_Stock.Value.ToString()));
            commandupdate.Parameters.AddWithValue("@p6", decimal.Parse(txt_PurchasePrice.Text));
            commandupdate.Parameters.AddWithValue("@p7", decimal.Parse(txt_SalePrice.Text));
            commandupdate.Parameters.AddWithValue("@p8", richtxt_Details.Text);
            commandupdate.Parameters.AddWithValue("@p9", txt_Id.Text);
            commandupdate.ExecuteNonQuery();
            connection.Connection();
            MessageBox.Show("Ürün bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();

        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }


    }
}
