
namespace Ticari_Otomasyon
{
    partial class Frm_Banks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Banks));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Grdcntrl_Banks = new DevExpress.XtraGrid.GridControl();
            this.cmbbx_Country = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbbx_City = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msktxb_Authorized = new System.Windows.Forms.MaskedTextBox();
            this.msktxb_AcountNo = new System.Windows.Forms.MaskedTextBox();
            this.msktxb_Iban = new System.Windows.Forms.MaskedTextBox();
            this.txt_AccountType = new DevExpress.XtraEditors.TextEdit();
            this.grpcntrl_Customers = new DevExpress.XtraEditors.GroupControl();
            this.Lookup_Compay = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_Clean = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.msktxb_Date = new System.Windows.Forms.MaskedTextBox();
            this.msktxb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Details = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Saleprice = new DevExpress.XtraEditors.LabelControl();
            this.lbl_PurchasePrice = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Stok = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Year = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Model = new DevExpress.XtraEditors.LabelControl();
            this.txt_BranchOffice = new DevExpress.XtraEditors.TextEdit();
            this.lbl_SupplierCompany = new DevExpress.XtraEditors.LabelControl();
            this.txt_BankName = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ProductName = new DevExpress.XtraEditors.LabelControl();
            this.txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Id = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcntrl_Banks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_Country.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_City.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcntrl_Customers)).BeginInit();
            this.grpcntrl_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lookup_Compay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BranchOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightCoral;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.Grdcntrl_Banks;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Grdcntrl_Banks
            // 
            this.Grdcntrl_Banks.Location = new System.Drawing.Point(1, 0);
            this.Grdcntrl_Banks.MainView = this.gridView1;
            this.Grdcntrl_Banks.Name = "Grdcntrl_Banks";
            this.Grdcntrl_Banks.Size = new System.Drawing.Size(1063, 560);
            this.Grdcntrl_Banks.TabIndex = 4;
            this.Grdcntrl_Banks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmbbx_Country
            // 
            this.cmbbx_Country.Location = new System.Drawing.Point(169, 133);
            this.cmbbx_Country.Name = "cmbbx_Country";
            this.cmbbx_Country.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbx_Country.Properties.Appearance.Options.UseFont = true;
            this.cmbbx_Country.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbx_Country.Size = new System.Drawing.Size(268, 24);
            this.cmbbx_Country.TabIndex = 3;
            // 
            // cmbbx_City
            // 
            this.cmbbx_City.Location = new System.Drawing.Point(169, 103);
            this.cmbbx_City.Name = "cmbbx_City";
            this.cmbbx_City.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbx_City.Properties.Appearance.Options.UseFont = true;
            this.cmbbx_City.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbx_City.Size = new System.Drawing.Size(268, 24);
            this.cmbbx_City.TabIndex = 2;
            this.cmbbx_City.SelectedIndexChanged += new System.EventHandler(this.cmbbx_City_SelectedIndexChanged);
            // 
            // msktxb_Authorized
            // 
            this.msktxb_Authorized.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_Authorized.Location = new System.Drawing.Point(169, 257);
            this.msktxb_Authorized.Name = "msktxb_Authorized";
            this.msktxb_Authorized.Size = new System.Drawing.Size(268, 25);
            this.msktxb_Authorized.TabIndex = 7;
            this.msktxb_Authorized.ValidatingType = typeof(int);
            // 
            // msktxb_AcountNo
            // 
            this.msktxb_AcountNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_AcountNo.Location = new System.Drawing.Point(169, 226);
            this.msktxb_AcountNo.Name = "msktxb_AcountNo";
            this.msktxb_AcountNo.Size = new System.Drawing.Size(268, 25);
            this.msktxb_AcountNo.TabIndex = 6;
            // 
            // msktxb_Iban
            // 
            this.msktxb_Iban.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_Iban.Location = new System.Drawing.Point(169, 194);
            this.msktxb_Iban.Name = "msktxb_Iban";
            this.msktxb_Iban.Size = new System.Drawing.Size(268, 25);
            this.msktxb_Iban.TabIndex = 5;
            this.msktxb_Iban.ValidatingType = typeof(int);
            // 
            // txt_AccountType
            // 
            this.txt_AccountType.Location = new System.Drawing.Point(169, 349);
            this.txt_AccountType.Name = "txt_AccountType";
            this.txt_AccountType.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_AccountType.Properties.Appearance.Options.UseFont = true;
            this.txt_AccountType.Size = new System.Drawing.Size(268, 24);
            this.txt_AccountType.TabIndex = 10;
            // 
            // grpcntrl_Customers
            // 
            this.grpcntrl_Customers.Controls.Add(this.Lookup_Compay);
            this.grpcntrl_Customers.Controls.Add(this.btn_Clean);
            this.grpcntrl_Customers.Controls.Add(this.btn_Update);
            this.grpcntrl_Customers.Controls.Add(this.btn_Delete);
            this.grpcntrl_Customers.Controls.Add(this.btn_Save);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_Date);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_Phone);
            this.grpcntrl_Customers.Controls.Add(this.labelControl3);
            this.grpcntrl_Customers.Controls.Add(this.cmbbx_Country);
            this.grpcntrl_Customers.Controls.Add(this.cmbbx_City);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_Authorized);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_AcountNo);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_Iban);
            this.grpcntrl_Customers.Controls.Add(this.labelControl2);
            this.grpcntrl_Customers.Controls.Add(this.labelControl1);
            this.grpcntrl_Customers.Controls.Add(this.txt_AccountType);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Details);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Saleprice);
            this.grpcntrl_Customers.Controls.Add(this.lbl_PurchasePrice);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Stok);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Year);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Model);
            this.grpcntrl_Customers.Controls.Add(this.txt_BranchOffice);
            this.grpcntrl_Customers.Controls.Add(this.lbl_SupplierCompany);
            this.grpcntrl_Customers.Controls.Add(this.txt_BankName);
            this.grpcntrl_Customers.Controls.Add(this.lbl_ProductName);
            this.grpcntrl_Customers.Controls.Add(this.txt_Id);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Id);
            this.grpcntrl_Customers.Location = new System.Drawing.Point(1070, 0);
            this.grpcntrl_Customers.Name = "grpcntrl_Customers";
            this.grpcntrl_Customers.Size = new System.Drawing.Size(456, 560);
            this.grpcntrl_Customers.TabIndex = 5;
            this.grpcntrl_Customers.Text = " ";
            // 
            // Lookup_Compay
            // 
            this.Lookup_Compay.Location = new System.Drawing.Point(169, 379);
            this.Lookup_Compay.Name = "Lookup_Compay";
            this.Lookup_Compay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lookup_Compay.Properties.Appearance.Options.UseFont = true;
            this.Lookup_Compay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lookup_Compay.Properties.NullText = "Bir Firma Seçiniz";
            this.Lookup_Compay.Size = new System.Drawing.Size(268, 24);
            this.Lookup_Compay.TabIndex = 11;
            // 
            // btn_Clean
            // 
            this.btn_Clean.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clean.Appearance.Options.UseFont = true;
            this.btn_Clean.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Clean.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Clean.ImageOptions.SvgImage")));
            this.btn_Clean.Location = new System.Drawing.Point(27, 485);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(196, 44);
            this.btn_Clean.TabIndex = 14;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Update.ImageOptions.SvgImage")));
            this.btn_Update.Location = new System.Drawing.Point(241, 485);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(196, 44);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "Update";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Location = new System.Drawing.Point(241, 425);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(196, 44);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Location = new System.Drawing.Point(27, 425);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(196, 44);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // msktxb_Date
            // 
            this.msktxb_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_Date.Location = new System.Drawing.Point(169, 319);
            this.msktxb_Date.Mask = "00/00/0000";
            this.msktxb_Date.Name = "msktxb_Date";
            this.msktxb_Date.Size = new System.Drawing.Size(268, 25);
            this.msktxb_Date.TabIndex = 9;
            this.msktxb_Date.ValidatingType = typeof(System.DateTime);
            // 
            // msktxb_Phone
            // 
            this.msktxb_Phone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_Phone.Location = new System.Drawing.Point(169, 288);
            this.msktxb_Phone.Mask = "(999) 000-0000";
            this.msktxb_Phone.Name = "msktxb_Phone";
            this.msktxb_Phone.Size = new System.Drawing.Size(268, 25);
            this.msktxb_Phone.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(107, 291);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 22);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Phone:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(91, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 22);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Country:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(124, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 22);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "City:";
            // 
            // lbl_Details
            // 
            this.lbl_Details.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.Appearance.Options.UseFont = true;
            this.lbl_Details.Location = new System.Drawing.Point(80, 379);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(83, 22);
            this.lbl_Details.TabIndex = 16;
            this.lbl_Details.Text = "Company:";
            // 
            // lbl_Saleprice
            // 
            this.lbl_Saleprice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saleprice.Appearance.Options.UseFont = true;
            this.lbl_Saleprice.Location = new System.Drawing.Point(50, 348);
            this.lbl_Saleprice.Name = "lbl_Saleprice";
            this.lbl_Saleprice.Size = new System.Drawing.Size(113, 22);
            this.lbl_Saleprice.TabIndex = 14;
            this.lbl_Saleprice.Text = "AccountType:";
            // 
            // lbl_PurchasePrice
            // 
            this.lbl_PurchasePrice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchasePrice.Appearance.Options.UseFont = true;
            this.lbl_PurchasePrice.Location = new System.Drawing.Point(119, 320);
            this.lbl_PurchasePrice.Name = "lbl_PurchasePrice";
            this.lbl_PurchasePrice.Size = new System.Drawing.Size(44, 22);
            this.lbl_PurchasePrice.TabIndex = 12;
            this.lbl_PurchasePrice.Text = "Date:";
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stok.Appearance.Options.UseFont = true;
            this.lbl_Stok.Location = new System.Drawing.Point(69, 256);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(94, 22);
            this.lbl_Stok.TabIndex = 11;
            this.lbl_Stok.Text = "Authorized:";
            // 
            // lbl_Year
            // 
            this.lbl_Year.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Appearance.Options.UseFont = true;
            this.lbl_Year.Location = new System.Drawing.Point(76, 228);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(87, 22);
            this.lbl_Year.TabIndex = 9;
            this.lbl_Year.Text = "AcountNo:";
            // 
            // lbl_Model
            // 
            this.lbl_Model.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Appearance.Options.UseFont = true;
            this.lbl_Model.Location = new System.Drawing.Point(121, 200);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(42, 22);
            this.lbl_Model.TabIndex = 7;
            this.lbl_Model.Text = "Iban:";
            // 
            // txt_BranchOffice
            // 
            this.txt_BranchOffice.Location = new System.Drawing.Point(169, 164);
            this.txt_BranchOffice.Name = "txt_BranchOffice";
            this.txt_BranchOffice.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BranchOffice.Properties.Appearance.Options.UseFont = true;
            this.txt_BranchOffice.Size = new System.Drawing.Size(268, 24);
            this.txt_BranchOffice.TabIndex = 4;
            // 
            // lbl_SupplierCompany
            // 
            this.lbl_SupplierCompany.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplierCompany.Appearance.Options.UseFont = true;
            this.lbl_SupplierCompany.Location = new System.Drawing.Point(48, 165);
            this.lbl_SupplierCompany.Name = "lbl_SupplierCompany";
            this.lbl_SupplierCompany.Size = new System.Drawing.Size(115, 22);
            this.lbl_SupplierCompany.TabIndex = 5;
            this.lbl_SupplierCompany.Text = "BranchOffice:";
            // 
            // txt_BankName
            // 
            this.txt_BankName.Location = new System.Drawing.Point(169, 74);
            this.txt_BankName.Name = "txt_BankName";
            this.txt_BankName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_BankName.Properties.Appearance.Options.UseFont = true;
            this.txt_BankName.Size = new System.Drawing.Size(268, 24);
            this.txt_BankName.TabIndex = 1;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductName.Appearance.Options.UseFont = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(66, 74);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(97, 22);
            this.lbl_ProductName.TabIndex = 3;
            this.lbl_ProductName.Text = "BankName:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(169, 44);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Id.Properties.Appearance.Options.UseFont = true;
            this.txt_Id.Size = new System.Drawing.Size(268, 24);
            this.txt_Id.TabIndex = 16;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Id.Appearance.Options.UseFont = true;
            this.lbl_Id.Location = new System.Drawing.Point(137, 47);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(22, 22);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Id:";
            // 
            // Frm_Banks
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Clean;
            this.ClientSize = new System.Drawing.Size(1526, 561);
            this.Controls.Add(this.grpcntrl_Customers);
            this.Controls.Add(this.Grdcntrl_Banks);
            this.Name = "Frm_Banks";
            this.Text = "BANKS";
            this.Load += new System.EventHandler(this.Frm_Banks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcntrl_Banks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_Country.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbx_City.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcntrl_Customers)).EndInit();
            this.grpcntrl_Customers.ResumeLayout(false);
            this.grpcntrl_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lookup_Compay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BranchOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl Grdcntrl_Banks;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbx_Country;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbx_City;
        private System.Windows.Forms.MaskedTextBox msktxb_Authorized;
        private System.Windows.Forms.MaskedTextBox msktxb_AcountNo;
        private System.Windows.Forms.MaskedTextBox msktxb_Iban;
        private DevExpress.XtraEditors.TextEdit txt_AccountType;
        private DevExpress.XtraEditors.GroupControl grpcntrl_Customers;
        private DevExpress.XtraEditors.LabelControl lbl_Details;
        private DevExpress.XtraEditors.LabelControl lbl_Saleprice;
        private DevExpress.XtraEditors.LabelControl lbl_PurchasePrice;
        private DevExpress.XtraEditors.LabelControl lbl_Stok;
        private DevExpress.XtraEditors.LabelControl lbl_Year;
        private DevExpress.XtraEditors.LabelControl lbl_Model;
        private DevExpress.XtraEditors.TextEdit txt_BranchOffice;
        private DevExpress.XtraEditors.LabelControl lbl_SupplierCompany;
        private DevExpress.XtraEditors.TextEdit txt_BankName;
        private DevExpress.XtraEditors.LabelControl lbl_ProductName;
        private DevExpress.XtraEditors.TextEdit txt_Id;
        private DevExpress.XtraEditors.LabelControl lbl_Id;
        private System.Windows.Forms.MaskedTextBox msktxb_Date;
        private System.Windows.Forms.MaskedTextBox msktxb_Phone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Clean;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.LookUpEdit Lookup_Compay;
    }
}