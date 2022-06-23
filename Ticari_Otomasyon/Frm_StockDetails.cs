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
    public partial class Frm_StockDetails : Form
    {
        public Frm_StockDetails()
        {
            InitializeComponent();
        }

        public string name;
        private Sql_Connection connection = new Sql_Connection();
        private void Frm_StockDetails_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("Select * from Products where ProductName='" + name + "'", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            grd_StockDetails.DataSource = dataTable;
              
        }
    }
}
 