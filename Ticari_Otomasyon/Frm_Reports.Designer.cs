
namespace Ticari_Otomasyon
{
    partial class Frm_Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reports));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DboTicariOtomasyonDataSet1 = new Ticari_Otomasyon.DboTicariOtomasyonDataSet1();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DboTicariOtomasyonDataSet3 = new Ticari_Otomasyon.DboTicariOtomasyonDataSet3();
            this.ExpensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DboTicariOtomasyonDataSet5 = new Ticari_Otomasyon.DboTicariOtomasyonDataSet5();
            this.PersonnelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DboTicariOtomasyonDataSet6 = new Ticari_Otomasyon.DboTicariOtomasyonDataSet6();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtratab_Companyy = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTab_Customer = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTab_Expense = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTab_Employees = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CompaniesTableAdapter = new Ticari_Otomasyon.DboTicariOtomasyonDataSet1TableAdapters.CompaniesTableAdapter();
            this.CustomersTableAdapter = new Ticari_Otomasyon.DboTicariOtomasyonDataSet3TableAdapters.CustomersTableAdapter();
            this.ExpensesTableAdapter = new Ticari_Otomasyon.DboTicariOtomasyonDataSet5TableAdapters.ExpensesTableAdapter();
            this.PersonnelsTableAdapter = new Ticari_Otomasyon.DboTicariOtomasyonDataSet6TableAdapters.PersonnelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtratab_Companyy.SuspendLayout();
            this.xtraTab_Customer.SuspendLayout();
            this.xtraTab_Expense.SuspendLayout();
            this.xtraTab_Employees.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompaniesBindingSource
            // 
            this.CompaniesBindingSource.DataMember = "Companies";
            this.CompaniesBindingSource.DataSource = this.DboTicariOtomasyonDataSet1;
            // 
            // DboTicariOtomasyonDataSet1
            // 
            this.DboTicariOtomasyonDataSet1.DataSetName = "DboTicariOtomasyonDataSet1";
            this.DboTicariOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.DboTicariOtomasyonDataSet3;
            // 
            // DboTicariOtomasyonDataSet3
            // 
            this.DboTicariOtomasyonDataSet3.DataSetName = "DboTicariOtomasyonDataSet3";
            this.DboTicariOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExpensesBindingSource
            // 
            this.ExpensesBindingSource.DataMember = "Expenses";
            this.ExpensesBindingSource.DataSource = this.DboTicariOtomasyonDataSet5;
            // 
            // DboTicariOtomasyonDataSet5
            // 
            this.DboTicariOtomasyonDataSet5.DataSetName = "DboTicariOtomasyonDataSet5";
            this.DboTicariOtomasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonnelsBindingSource
            // 
            this.PersonnelsBindingSource.DataMember = "Personnels";
            this.PersonnelsBindingSource.DataSource = this.DboTicariOtomasyonDataSet6;
            // 
            // DboTicariOtomasyonDataSet6
            // 
            this.DboTicariOtomasyonDataSet6.DataSetName = "DboTicariOtomasyonDataSet6";
            this.DboTicariOtomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtratab_Companyy;
            this.xtraTabControl1.Size = new System.Drawing.Size(1526, 561);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtratab_Companyy,
            this.xtraTab_Customer,
            this.xtraTab_Expense,
            this.xtraTab_Employees});
            // 
            // xtratab_Companyy
            // 
            this.xtratab_Companyy.Controls.Add(this.reportViewer1);
            this.xtratab_Companyy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtratab_Companyy.ImageOptions.SvgImage")));
            this.xtratab_Companyy.Name = "xtratab_Companyy";
            this.xtratab_Companyy.Size = new System.Drawing.Size(1524, 517);
            this.xtratab_Companyy.Text = "Company Reports";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 66;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CompaniesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1524, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTab_Customer
            // 
            this.xtraTab_Customer.Controls.Add(this.reportViewer2);
            this.xtraTab_Customer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTab_Customer.ImageOptions.SvgImage")));
            this.xtraTab_Customer.Name = "xtraTab_Customer";
            this.xtraTab_Customer.Size = new System.Drawing.Size(1524, 517);
            this.xtraTab_Customer.Text = " Customer Reports";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1Customers";
            reportDataSource2.Value = this.CustomersBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1524, 517);
            this.reportViewer2.TabIndex = 0;
            // 
            // xtraTab_Expense
            // 
            this.xtraTab_Expense.Controls.Add(this.reportViewer4);
            this.xtraTab_Expense.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTab_Expense.ImageOptions.SvgImage")));
            this.xtraTab_Expense.Name = "xtraTab_Expense";
            this.xtraTab_Expense.Size = new System.Drawing.Size(1524, 517);
            this.xtraTab_Expense.Text = "Expense Reports";
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1Expenses";
            reportDataSource3.Value = this.ExpensesBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.Report3.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1524, 517);
            this.reportViewer4.TabIndex = 0;
            // 
            // xtraTab_Employees
            // 
            this.xtraTab_Employees.Controls.Add(this.reportViewer5);
            this.xtraTab_Employees.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtraTab_Employees.ImageOptions.SvgImage")));
            this.xtraTab_Employees.Name = "xtraTab_Employees";
            this.xtraTab_Employees.Size = new System.Drawing.Size(1524, 517);
            this.xtraTab_Employees.Text = "Employees Reports";
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1Personnel";
            reportDataSource4.Value = this.PersonnelsBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Ticari_Otomasyon.Report4.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 0);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1524, 517);
            this.reportViewer5.TabIndex = 0;
            // 
            // CompaniesTableAdapter
            // 
            this.CompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // CustomersTableAdapter
            // 
            this.CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // ExpensesTableAdapter
            // 
            this.ExpensesTableAdapter.ClearBeforeFill = true;
            // 
            // PersonnelsTableAdapter
            // 
            this.PersonnelsTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 561);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Frm_Reports";
            this.Text = "REPORTS";
            this.Load += new System.EventHandler(this.Frm_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DboTicariOtomasyonDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtratab_Companyy.ResumeLayout(false);
            this.xtraTab_Customer.ResumeLayout(false);
            this.xtraTab_Expense.ResumeLayout(false);
            this.xtraTab_Employees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtratab_Companyy;
        private DevExpress.XtraTab.XtraTabPage xtraTab_Customer;
        private DevExpress.XtraTab.XtraTabPage xtraTab_Expense;
        private DevExpress.XtraTab.XtraTabPage xtraTab_Employees;
        private System.Windows.Forms.BindingSource CompaniesBindingSource;
        private DboTicariOtomasyonDataSet1 DboTicariOtomasyonDataSet1;
        private DboTicariOtomasyonDataSet1TableAdapters.CompaniesTableAdapter CompaniesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private DboTicariOtomasyonDataSet3 DboTicariOtomasyonDataSet3;
        private DboTicariOtomasyonDataSet3TableAdapters.CustomersTableAdapter CustomersTableAdapter;
        private System.Windows.Forms.BindingSource ExpensesBindingSource;
        private DboTicariOtomasyonDataSet5 DboTicariOtomasyonDataSet5;
        private DboTicariOtomasyonDataSet5TableAdapters.ExpensesTableAdapter ExpensesTableAdapter;
        private System.Windows.Forms.BindingSource PersonnelsBindingSource;
        private DboTicariOtomasyonDataSet6 DboTicariOtomasyonDataSet6;
        private DboTicariOtomasyonDataSet6TableAdapters.PersonnelsTableAdapter PersonnelsTableAdapter;
    }
}