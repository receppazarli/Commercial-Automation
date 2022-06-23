
namespace Ticari_Otomasyon
{
    partial class Frm_Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Expenses));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Grdcntrl_Expenses = new DevExpress.XtraGrid.GridControl();
            this.cmbbx_Month = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Extra = new DevExpress.XtraEditors.TextEdit();
            this.grpcntrl_Customers = new DevExpress.XtraEditors.GroupControl();
            this.rch_Notes = new System.Windows.Forms.RichTextBox();
            this.txt_Salaries = new DevExpress.XtraEditors.TextEdit();
            this.txt_NaturalGazInvoice = new DevExpress.XtraEditors.TextEdit();
            this.txt_WaterInvoice = new DevExpress.XtraEditors.TextEdit();
            this.txt_ElectricInvoice = new DevExpress.XtraEditors.TextEdit();
            this.cmbbx_Year = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_Clean = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.brn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_Saleprice = new DevExpress.XtraEditors.LabelControl();
            this.txt_InternetInvoice = new DevExpress.XtraEditors.TextEdit();
            this.lbl_PurchasePrice = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Stok = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Year = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Model = new DevExpress.XtraEditors.LabelControl();
            this.lbl_SupplierCompany = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ProductName = new DevExpress.XtraEditors.LabelControl();
            this.txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Id = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcntrl_Expenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_Month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Extra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcntrl_Customers)).BeginInit();
            this.grpcntrl_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Salaries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NaturalGazInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WaterInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ElectricInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_Year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_InternetInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightCoral;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.Grdcntrl_Expenses;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Grdcntrl_Expenses
            // 
            this.Grdcntrl_Expenses.Location = new System.Drawing.Point(1, 0);
            this.Grdcntrl_Expenses.MainView = this.gridView1;
            this.Grdcntrl_Expenses.Name = "Grdcntrl_Expenses";
            this.Grdcntrl_Expenses.Size = new System.Drawing.Size(1066, 560);
            this.Grdcntrl_Expenses.TabIndex = 4;
            this.Grdcntrl_Expenses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmbbx_Month
            // 
            this.cmbbx_Month.Location = new System.Drawing.Point(169, 74);
            this.cmbbx_Month.Name = "cmbbx_Month";
            this.cmbbx_Month.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbx_Month.Properties.Appearance.Options.UseFont = true;
            this.cmbbx_Month.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbx_Month.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbbx_Month.Size = new System.Drawing.Size(268, 24);
            this.cmbbx_Month.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(111, 316);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 22);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Notes:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(112, 284);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 22);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Extra:";
            // 
            // txt_Extra
            // 
            this.txt_Extra.Location = new System.Drawing.Point(169, 284);
            this.txt_Extra.Name = "txt_Extra";
            this.txt_Extra.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Extra.Properties.Appearance.Options.UseFont = true;
            this.txt_Extra.Size = new System.Drawing.Size(268, 24);
            this.txt_Extra.TabIndex = 8;
            // 
            // grpcntrl_Customers
            // 
            this.grpcntrl_Customers.Controls.Add(this.rch_Notes);
            this.grpcntrl_Customers.Controls.Add(this.txt_Salaries);
            this.grpcntrl_Customers.Controls.Add(this.txt_NaturalGazInvoice);
            this.grpcntrl_Customers.Controls.Add(this.txt_WaterInvoice);
            this.grpcntrl_Customers.Controls.Add(this.txt_ElectricInvoice);
            this.grpcntrl_Customers.Controls.Add(this.cmbbx_Year);
            this.grpcntrl_Customers.Controls.Add(this.btn_Clean);
            this.grpcntrl_Customers.Controls.Add(this.btn_Update);
            this.grpcntrl_Customers.Controls.Add(this.brn_Delete);
            this.grpcntrl_Customers.Controls.Add(this.btn_Save);
            this.grpcntrl_Customers.Controls.Add(this.cmbbx_Month);
            this.grpcntrl_Customers.Controls.Add(this.labelControl2);
            this.grpcntrl_Customers.Controls.Add(this.labelControl1);
            this.grpcntrl_Customers.Controls.Add(this.txt_Extra);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Saleprice);
            this.grpcntrl_Customers.Controls.Add(this.txt_InternetInvoice);
            this.grpcntrl_Customers.Controls.Add(this.lbl_PurchasePrice);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Stok);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Year);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Model);
            this.grpcntrl_Customers.Controls.Add(this.lbl_SupplierCompany);
            this.grpcntrl_Customers.Controls.Add(this.lbl_ProductName);
            this.grpcntrl_Customers.Controls.Add(this.txt_Id);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Id);
            this.grpcntrl_Customers.Location = new System.Drawing.Point(1070, 0);
            this.grpcntrl_Customers.Name = "grpcntrl_Customers";
            this.grpcntrl_Customers.Size = new System.Drawing.Size(456, 560);
            this.grpcntrl_Customers.TabIndex = 5;
            this.grpcntrl_Customers.Text = " ";
            // 
            // rch_Notes
            // 
            this.rch_Notes.Location = new System.Drawing.Point(169, 314);
            this.rch_Notes.Name = "rch_Notes";
            this.rch_Notes.Size = new System.Drawing.Size(268, 96);
            this.rch_Notes.TabIndex = 9;
            this.rch_Notes.Text = "";
            // 
            // txt_Salaries
            // 
            this.txt_Salaries.Location = new System.Drawing.Point(169, 254);
            this.txt_Salaries.Name = "txt_Salaries";
            this.txt_Salaries.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Salaries.Properties.Appearance.Options.UseFont = true;
            this.txt_Salaries.Size = new System.Drawing.Size(268, 24);
            this.txt_Salaries.TabIndex = 7;
            // 
            // txt_NaturalGazInvoice
            // 
            this.txt_NaturalGazInvoice.Location = new System.Drawing.Point(169, 194);
            this.txt_NaturalGazInvoice.Name = "txt_NaturalGazInvoice";
            this.txt_NaturalGazInvoice.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_NaturalGazInvoice.Properties.Appearance.Options.UseFont = true;
            this.txt_NaturalGazInvoice.Size = new System.Drawing.Size(268, 24);
            this.txt_NaturalGazInvoice.TabIndex = 5;
            // 
            // txt_WaterInvoice
            // 
            this.txt_WaterInvoice.Location = new System.Drawing.Point(169, 164);
            this.txt_WaterInvoice.Name = "txt_WaterInvoice";
            this.txt_WaterInvoice.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WaterInvoice.Properties.Appearance.Options.UseFont = true;
            this.txt_WaterInvoice.Size = new System.Drawing.Size(268, 24);
            this.txt_WaterInvoice.TabIndex = 4;
            // 
            // txt_ElectricInvoice
            // 
            this.txt_ElectricInvoice.Location = new System.Drawing.Point(169, 134);
            this.txt_ElectricInvoice.Name = "txt_ElectricInvoice";
            this.txt_ElectricInvoice.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ElectricInvoice.Properties.Appearance.Options.UseFont = true;
            this.txt_ElectricInvoice.Size = new System.Drawing.Size(268, 24);
            this.txt_ElectricInvoice.TabIndex = 3;
            // 
            // cmbbx_Year
            // 
            this.cmbbx_Year.Location = new System.Drawing.Point(169, 104);
            this.cmbbx_Year.Name = "cmbbx_Year";
            this.cmbbx_Year.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbx_Year.Properties.Appearance.Options.UseFont = true;
            this.cmbbx_Year.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbx_Year.Properties.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbbx_Year.Size = new System.Drawing.Size(268, 24);
            this.cmbbx_Year.TabIndex = 2;
            // 
            // btn_Clean
            // 
            this.btn_Clean.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clean.Appearance.Options.UseFont = true;
            this.btn_Clean.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Clean.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Clean.ImageOptions.SvgImage")));
            this.btn_Clean.Location = new System.Drawing.Point(14, 477);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(196, 44);
            this.btn_Clean.TabIndex = 12;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Update.ImageOptions.SvgImage")));
            this.btn_Update.Location = new System.Drawing.Point(241, 477);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(196, 44);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // brn_Delete
            // 
            this.brn_Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brn_Delete.Appearance.Options.UseFont = true;
            this.brn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brn_Delete.ImageOptions.SvgImage")));
            this.brn_Delete.Location = new System.Drawing.Point(241, 427);
            this.brn_Delete.Name = "brn_Delete";
            this.brn_Delete.Size = new System.Drawing.Size(196, 44);
            this.brn_Delete.TabIndex = 11;
            this.brn_Delete.Text = "Delete";
            this.brn_Delete.Click += new System.EventHandler(this.brn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Location = new System.Drawing.Point(14, 427);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(196, 44);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Saleprice
            // 
            this.lbl_Saleprice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saleprice.Appearance.Options.UseFont = true;
            this.lbl_Saleprice.Location = new System.Drawing.Point(92, 256);
            this.lbl_Saleprice.Name = "lbl_Saleprice";
            this.lbl_Saleprice.Size = new System.Drawing.Size(71, 22);
            this.lbl_Saleprice.TabIndex = 14;
            this.lbl_Saleprice.Text = "Salaries:";
            // 
            // txt_InternetInvoice
            // 
            this.txt_InternetInvoice.Location = new System.Drawing.Point(169, 224);
            this.txt_InternetInvoice.Name = "txt_InternetInvoice";
            this.txt_InternetInvoice.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_InternetInvoice.Properties.Appearance.Options.UseFont = true;
            this.txt_InternetInvoice.Size = new System.Drawing.Size(268, 24);
            this.txt_InternetInvoice.TabIndex = 6;
            // 
            // lbl_PurchasePrice
            // 
            this.lbl_PurchasePrice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchasePrice.Appearance.Options.UseFont = true;
            this.lbl_PurchasePrice.Location = new System.Drawing.Point(34, 226);
            this.lbl_PurchasePrice.Name = "lbl_PurchasePrice";
            this.lbl_PurchasePrice.Size = new System.Drawing.Size(129, 22);
            this.lbl_PurchasePrice.TabIndex = 12;
            this.lbl_PurchasePrice.Text = "InternetInvoice:";
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stok.Appearance.Options.UseFont = true;
            this.lbl_Stok.Location = new System.Drawing.Point(3, 196);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(160, 22);
            this.lbl_Stok.TabIndex = 11;
            this.lbl_Stok.Text = "NaturalGazInvoice:";
            // 
            // lbl_Year
            // 
            this.lbl_Year.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Appearance.Options.UseFont = true;
            this.lbl_Year.Location = new System.Drawing.Point(47, 165);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(116, 22);
            this.lbl_Year.TabIndex = 9;
            this.lbl_Year.Text = "WaterInvoice:";
            // 
            // lbl_Model
            // 
            this.lbl_Model.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Appearance.Options.UseFont = true;
            this.lbl_Model.Location = new System.Drawing.Point(35, 133);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(128, 22);
            this.lbl_Model.TabIndex = 7;
            this.lbl_Model.Text = "ElectricInvoice:";
            // 
            // lbl_SupplierCompany
            // 
            this.lbl_SupplierCompany.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplierCompany.Appearance.Options.UseFont = true;
            this.lbl_SupplierCompany.Location = new System.Drawing.Point(118, 104);
            this.lbl_SupplierCompany.Name = "lbl_SupplierCompany";
            this.lbl_SupplierCompany.Size = new System.Drawing.Size(45, 22);
            this.lbl_SupplierCompany.TabIndex = 5;
            this.lbl_SupplierCompany.Text = "Year:";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductName.Appearance.Options.UseFont = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(104, 76);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(59, 22);
            this.lbl_ProductName.TabIndex = 3;
            this.lbl_ProductName.Text = "Month:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(169, 44);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Id.Properties.Appearance.Options.UseFont = true;
            this.txt_Id.Size = new System.Drawing.Size(268, 24);
            this.txt_Id.TabIndex = 14;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Id.Appearance.Options.UseFont = true;
            this.lbl_Id.Location = new System.Drawing.Point(137, 48);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(26, 22);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID:";
            // 
            // Frm_Expenses
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Clean;
            this.ClientSize = new System.Drawing.Size(1526, 561);
            this.Controls.Add(this.grpcntrl_Customers);
            this.Controls.Add(this.Grdcntrl_Expenses);
            this.Name = "Frm_Expenses";
            this.Text = "EXPENSES";
            this.Load += new System.EventHandler(this.Frm_Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcntrl_Expenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_Month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Extra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcntrl_Customers)).EndInit();
            this.grpcntrl_Customers.ResumeLayout(false);
            this.grpcntrl_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Salaries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NaturalGazInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_WaterInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ElectricInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_Year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_InternetInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl Grdcntrl_Expenses;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbx_Month;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Extra;
        private DevExpress.XtraEditors.GroupControl grpcntrl_Customers;
        private DevExpress.XtraEditors.LabelControl lbl_Saleprice;
        private DevExpress.XtraEditors.TextEdit txt_InternetInvoice;
        private DevExpress.XtraEditors.LabelControl lbl_PurchasePrice;
        private DevExpress.XtraEditors.LabelControl lbl_Stok;
        private DevExpress.XtraEditors.LabelControl lbl_Year;
        private DevExpress.XtraEditors.LabelControl lbl_Model;
        private DevExpress.XtraEditors.LabelControl lbl_SupplierCompany;
        private DevExpress.XtraEditors.LabelControl lbl_ProductName;
        private DevExpress.XtraEditors.TextEdit txt_Id;
        private DevExpress.XtraEditors.LabelControl lbl_Id;
        private DevExpress.XtraEditors.SimpleButton btn_Clean;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton brn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit txt_Salaries;
        private DevExpress.XtraEditors.TextEdit txt_NaturalGazInvoice;
        private DevExpress.XtraEditors.TextEdit txt_WaterInvoice;
        private DevExpress.XtraEditors.TextEdit txt_ElectricInvoice;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbx_Year;
        private System.Windows.Forms.RichTextBox rch_Notes;
    }
}