using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Frm_Reports : Form
    {
        public Frm_Reports()
        {
            InitializeComponent();
        }

        private void Frm_Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet6.Personnels' table. You can move, or remove it, as needed.
            this.PersonnelsTableAdapter.Fill(this.DboTicariOtomasyonDataSet6.Personnels);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet5.Expenses' table. You can move, or remove it, as needed.
            this.ExpensesTableAdapter.Fill(this.DboTicariOtomasyonDataSet5.Expenses);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet3.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.Fill(this.DboTicariOtomasyonDataSet3.Customers);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonDataSet1.Companies' table. You can move, or remove it, as needed.
            this.CompaniesTableAdapter.Fill(this.DboTicariOtomasyonDataSet1.Companies);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
