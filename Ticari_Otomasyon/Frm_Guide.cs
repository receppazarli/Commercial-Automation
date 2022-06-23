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
    public partial class Frm_Guide : Form
    {
        public Frm_Guide()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();

        void ListCustomers()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("Select FirstName,LastName,Phone,Phone2,Mail from Customers order by FirstName", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Customers.DataSource = dataTable;
        }


        void ListCompanies()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select CompanyName,ContactFirstAndLastName,Phone1,Phone2,Phone3,Mail,Fax from Companies order by CompanyName ", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            grdcntrl_Companies.DataSource = dataTable;
        }

        private void Frm_Guide_Load(object sender, EventArgs e)
        {
           ListCustomers();
           ListCompanies();
        }

        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_Mail frmMail = new Frm_Mail();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow!=null)
            {
                frmMail.mail = dataRow["Mail"].ToString();
            }
            frmMail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            Frm_Mail frmMail = new Frm_Mail();
            DataRow dataRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dataRow != null)
            {
                frmMail.mail = dataRow["Mail"].ToString();
            }
            frmMail.Show();

        }
    }
}
