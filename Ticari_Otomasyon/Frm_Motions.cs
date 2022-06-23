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
    public partial class Frm_Motions : Form
    {
        public Frm_Motions()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();

        void CompanyMotion()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Exec CompanyMotion", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            grdcntrl_CompanyMotion.DataSource = dataTable; 
        }

        void CustomerMotion()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Exec CustomerMotion", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_CustomerMotion.DataSource = dataTable;
        }

        private void Frm_Motions_Load(object sender, EventArgs e)
        {
            CompanyMotion();
            CustomerMotion();
        }
    }
}
