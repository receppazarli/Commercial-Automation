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
    public partial class Frm_AnaModul : Form
    {
        public Frm_AnaModul()
        {
            InitializeComponent();
        }

        private Frm_Products frmProducts;
        private void btn_Products_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmProducts == null)
            {
                frmProducts = new Frm_Products();
                frmProducts.MdiParent = this;
                frmProducts.Show();
            }
        }

        public string user;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (frmHomePage == null)
            {
                frmHomePage = new Frm_HomePage();
                frmHomePage.MdiParent = this;
                frmHomePage.Show();
            }
        }


        private Frm_Customers frmCustomers;
        private void btn_Customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCustomers == null)
            {
                frmCustomers = new Frm_Customers();
                frmCustomers.MdiParent = this;
                frmCustomers.Show();
            }

        }

        private Frm_Companies frmCompanies;
        private void btn_Companıes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCompanies == null)
            {
                frmCompanies = new Frm_Companies();
                frmCompanies.MdiParent = this;
                frmCompanies.Show();
            }
        }

        private Frm_Personnels frmPersonnel;
        private void btn_Employees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonnel == null)
            {
                frmPersonnel = new Frm_Personnels();
                frmPersonnel.MdiParent = this;
                frmPersonnel.Show();
            }

        }

        private Frm_Guide frmGuide;
        private void btn_Guide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGuide == null)
            {
                frmGuide = new Frm_Guide();
                frmGuide.MdiParent = this;
                frmGuide.Show();
            }

        }

        private Frm_Expenses frmExpenses;
        private void btn_Expenses_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmExpenses == null)
            {
                frmExpenses = new Frm_Expenses();
                frmExpenses.MdiParent = this;
                frmExpenses.Show();
            }
        }


        
        private Frm_Banks frmBanks;
        private void btn_Banks_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBanks == null)
            {
                frmBanks = new Frm_Banks();
                frmBanks.MdiParent = this;
                frmBanks.Show();
            }
        }

        private Frm_Invoice frmInvoice;
        private void btn_Invoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new Frm_Invoice();
                frmInvoice.MdiParent = this;
                frmInvoice.Show();
            }
        }

        private Frm_Notes frmNotes;
        private void btn_Notes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotes==null)
            {
                frmNotes = new Frm_Notes();
                frmNotes.MdiParent = this;
                frmNotes.Show();
            }
        }

        private Frm_Motions frmMotions;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMotions==null)
            {
                frmMotions = new Frm_Motions();
                frmMotions.MdiParent = this;
                frmMotions.Show();
            }
        }

        private Frm_Reports frmReports;
        private void btn_Reports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmReports==null)
            {
                frmReports = new Frm_Reports();
                frmReports.MdiParent = this;
                frmReports.Show();
            }
        }

        private Frm_Stocks frmStocks;
        private void btn_Stocks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmStocks==null)
            {
                frmStocks = new Frm_Stocks();
                frmStocks.MdiParent = this;
                frmStocks.Show();
            }
        }

        private Frm_Settings frmSettings;
        private void btn_Settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSettings==null)
            {
                frmSettings = new Frm_Settings();
                frmSettings.Show();
            }
        }

        private Frm_Safe frmSafe;
        private void btn_Safe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSafe==null)
            {
                frmSafe = new Frm_Safe();
                frmSafe.name = user;
                frmSafe.MdiParent = this;
                frmSafe.Show();
            }
        }

        private Frm_HomePage frmHomePage;
        private void btn_HomePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHomePage==null)
            {
                frmHomePage = new Frm_HomePage();
                frmHomePage.MdiParent = this;
                frmHomePage.Show();
            }
        }
    }
}



