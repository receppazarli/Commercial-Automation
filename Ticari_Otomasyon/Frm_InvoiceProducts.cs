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
    public partial class Frm_InvoiceProducts : Form
    {
        public Frm_InvoiceProducts()
        {
            InitializeComponent();
        }

        public string Id;
        private Sql_Connection connection = new Sql_Connection();

        void List()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from InvoiceDetail where InvoiceId='" + Id + "'",
                connection.Connection());
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void Frm_InvoiceProducts_Load(object sender, EventArgs e)
        {
            List();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_InvoiceProductArrangement frmInvoiceProductArrangement = new Frm_InvoiceProductArrangement();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                frmInvoiceProductArrangement.ProductId = dataRow["InvoiceProductId"].ToString();
            }
            frmInvoiceProductArrangement.Show();
        }
    }
}
