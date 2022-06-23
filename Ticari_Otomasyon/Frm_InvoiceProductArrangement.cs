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
    public partial class Frm_InvoiceProductArrangement : Form
    {
        public Frm_InvoiceProductArrangement()
        {
            InitializeComponent();
        }

        public string ProductId;
        private Sql_Connection connection = new Sql_Connection();
        private void Frm_InvoiceProductArrangement_Load(object sender, EventArgs e)
        {
            txt_InvoiceProductId.Text = ProductId;

            SqlCommand command = new SqlCommand("Select  * from InvoiceDetail where InvoiceProductId=@InvoiceProductId", connection.Connection());
            command.Parameters.AddWithValue("@InvoiceProductId", ProductId);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                txt_Price.Text = sqlDataReader[3].ToString();
                txt_Miktar.Text = sqlDataReader[2].ToString();
                txt_Tutar.Text = sqlDataReader[4].ToString();
                txt_ProductName.Text = sqlDataReader[1].ToString();

                connection.Connection().Close();
            }


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command =
                new SqlCommand(
                    "Update InvoiceDetail set ProductName=@ProductName,Miktar=@Miktar,Price=@Price,Tutar=@Tutar where InvoiceProductId=@InvoiceProductId",
                    connection.Connection());
            command.Parameters.AddWithValue("@ProductName", txt_ProductName.Text);
            command.Parameters.AddWithValue("@Miktar", txt_Miktar.Text);
            command.Parameters.AddWithValue("@Price", decimal.Parse(txt_Price.Text));
            command.Parameters.AddWithValue("@Tutar", decimal.Parse(txt_Tutar.Text));
            command.Parameters.AddWithValue("@InvoiceProductId", txt_InvoiceProductId.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();

            MessageBox.Show("Değişiklikler kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from InvoiceDetail where InvoiceProductId=@InvoiceProductId",
                connection.Connection());
            command.Parameters.AddWithValue("@InvoiceProductId", txt_InvoiceProductId.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             
        }
    }
}
