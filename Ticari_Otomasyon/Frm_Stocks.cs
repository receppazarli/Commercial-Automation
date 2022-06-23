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
    public partial class Frm_Stocks : Form
    {
        public Frm_Stocks()
        {
            InitializeComponent();
        }

        void GridList()  // gride verileri çekme stock verilerini
        {
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("Select ProductName,sum(Stock) as Quantity from Products  group by ProductName",
                    connection.Connection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Stocks.DataSource = dataTable;
        }

        private void StockList()
        {
            // charta stok miktarini listeleme
            SqlCommand command =
                new SqlCommand("Select ProductName,sum(Stock) as Quantity from Products  group by ProductName",
                    connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(sqlDataReader[0]),
                    int.Parse(sqlDataReader[1].ToString()));


                // bu şekilde de yukarıda yaptırmak istediğimiz yaptırabiliyorum .
                //chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(sqlDataReader[0]),
                //    Convert.ToInt32(sqlDataReader[1]));
            }
            connection.Connection().Close();
        }

        void CompanyList()
        {
            SqlCommand command = new SqlCommand("Select City,Count(*) from Companies group by City",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(sqlDataReader[0]),
                    Convert.ToInt32(sqlDataReader[1]));
            }

            connection.Connection();
        }

        private Sql_Connection connection = new Sql_Connection(); 
        private void Frm_Stocks_Load(object sender, EventArgs e)
        {
           
            GridList();
            StockList();
            CompanyList();

            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_StockDetails frmStockDetails = new Frm_StockDetails();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                frmStockDetails.name = dataRow["ProductName"].ToString();
            }
            frmStockDetails.Show();
        }
    }
}
