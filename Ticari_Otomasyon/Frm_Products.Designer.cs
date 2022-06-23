
namespace Ticari_Otomasyon
{
    partial class Frm_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Products));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Clean = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.richtxt_Details = new System.Windows.Forms.RichTextBox();
            this.lbl_Details = new DevExpress.XtraEditors.LabelControl();
            this.txt_SalePrice = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Saleprice = new DevExpress.XtraEditors.LabelControl();
            this.txt_PurchasePrice = new DevExpress.XtraEditors.TextEdit();
            this.lbl_PurchasePrice = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Stok = new DevExpress.XtraEditors.LabelControl();
            this.nmrcUD_Stock = new System.Windows.Forms.NumericUpDown();
            this.lbl_Year = new DevExpress.XtraEditors.LabelControl();
            this.txt_Model = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Model = new DevExpress.XtraEditors.LabelControl();
            this.txt_SupplierCompany = new DevExpress.XtraEditors.TextEdit();
            this.lbl_SupplierCompany = new DevExpress.XtraEditors.LabelControl();
            this.txt_ProductName = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ProductName = new DevExpress.XtraEditors.LabelControl();
            this.mskdtxt_Year = new System.Windows.Forms.MaskedTextBox();
            this.txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Id = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUD_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SupplierCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1063, 560);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightCoral;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Clean);
            this.groupControl1.Controls.Add(this.btn_Update);
            this.groupControl1.Controls.Add(this.btn_Delete);
            this.groupControl1.Controls.Add(this.btn_Save);
            this.groupControl1.Controls.Add(this.richtxt_Details);
            this.groupControl1.Controls.Add(this.lbl_Details);
            this.groupControl1.Controls.Add(this.txt_SalePrice);
            this.groupControl1.Controls.Add(this.lbl_Saleprice);
            this.groupControl1.Controls.Add(this.txt_PurchasePrice);
            this.groupControl1.Controls.Add(this.lbl_PurchasePrice);
            this.groupControl1.Controls.Add(this.lbl_Stok);
            this.groupControl1.Controls.Add(this.nmrcUD_Stock);
            this.groupControl1.Controls.Add(this.lbl_Year);
            this.groupControl1.Controls.Add(this.txt_Model);
            this.groupControl1.Controls.Add(this.lbl_Model);
            this.groupControl1.Controls.Add(this.txt_SupplierCompany);
            this.groupControl1.Controls.Add(this.lbl_SupplierCompany);
            this.groupControl1.Controls.Add(this.txt_ProductName);
            this.groupControl1.Controls.Add(this.lbl_ProductName);
            this.groupControl1.Controls.Add(this.mskdtxt_Year);
            this.groupControl1.Controls.Add(this.txt_Id);
            this.groupControl1.Controls.Add(this.lbl_Id);
            this.groupControl1.Location = new System.Drawing.Point(1069, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(456, 560);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = " ";
            // 
            // btn_Clean
            // 
            this.btn_Clean.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clean.Appearance.Options.UseFont = true;
            this.btn_Clean.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Clean.ImageOptions.SvgImage")));
            this.btn_Clean.Location = new System.Drawing.Point(30, 483);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(198, 44);
            this.btn_Clean.TabIndex = 11;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Update.ImageOptions.SvgImage")));
            this.btn_Update.Location = new System.Drawing.Point(240, 483);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(198, 44);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Location = new System.Drawing.Point(239, 418);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(198, 44);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Location = new System.Drawing.Point(30, 418);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(198, 44);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // richtxt_Details
            // 
            this.richtxt_Details.Location = new System.Drawing.Point(169, 290);
            this.richtxt_Details.Name = "richtxt_Details";
            this.richtxt_Details.Size = new System.Drawing.Size(268, 96);
            this.richtxt_Details.TabIndex = 8;
            this.richtxt_Details.Text = "";
            // 
            // lbl_Details
            // 
            this.lbl_Details.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.Appearance.Options.UseFont = true;
            this.lbl_Details.Location = new System.Drawing.Point(92, 287);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(62, 22);
            this.lbl_Details.TabIndex = 16;
            this.lbl_Details.Text = "Details:";
            // 
            // txt_SalePrice
            // 
            this.txt_SalePrice.Location = new System.Drawing.Point(169, 257);
            this.txt_SalePrice.Name = "txt_SalePrice";
            this.txt_SalePrice.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SalePrice.Properties.Appearance.Options.UseFont = true;
            this.txt_SalePrice.Size = new System.Drawing.Size(268, 24);
            this.txt_SalePrice.TabIndex = 7;
            // 
            // lbl_Saleprice
            // 
            this.lbl_Saleprice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saleprice.Appearance.Options.UseFont = true;
            this.lbl_Saleprice.Location = new System.Drawing.Point(71, 257);
            this.lbl_Saleprice.Name = "lbl_Saleprice";
            this.lbl_Saleprice.Size = new System.Drawing.Size(88, 22);
            this.lbl_Saleprice.TabIndex = 14;
            this.lbl_Saleprice.Text = "Sale Price:";
            // 
            // txt_PurchasePrice
            // 
            this.txt_PurchasePrice.Location = new System.Drawing.Point(169, 227);
            this.txt_PurchasePrice.Name = "txt_PurchasePrice";
            this.txt_PurchasePrice.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_PurchasePrice.Properties.Appearance.Options.UseFont = true;
            this.txt_PurchasePrice.Size = new System.Drawing.Size(268, 24);
            this.txt_PurchasePrice.TabIndex = 6;
            // 
            // lbl_PurchasePrice
            // 
            this.lbl_PurchasePrice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchasePrice.Appearance.Options.UseFont = true;
            this.lbl_PurchasePrice.Location = new System.Drawing.Point(30, 227);
            this.lbl_PurchasePrice.Name = "lbl_PurchasePrice";
            this.lbl_PurchasePrice.Size = new System.Drawing.Size(129, 22);
            this.lbl_PurchasePrice.TabIndex = 12;
            this.lbl_PurchasePrice.Text = "Purchase Price:";
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stok.Appearance.Options.UseFont = true;
            this.lbl_Stok.Location = new System.Drawing.Point(111, 194);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(52, 22);
            this.lbl_Stok.TabIndex = 11;
            this.lbl_Stok.Text = "Stock:";
            // 
            // nmrcUD_Stock
            // 
            this.nmrcUD_Stock.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrcUD_Stock.Location = new System.Drawing.Point(169, 195);
            this.nmrcUD_Stock.Name = "nmrcUD_Stock";
            this.nmrcUD_Stock.Size = new System.Drawing.Size(268, 25);
            this.nmrcUD_Stock.TabIndex = 5;
            // 
            // lbl_Year
            // 
            this.lbl_Year.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Appearance.Options.UseFont = true;
            this.lbl_Year.Location = new System.Drawing.Point(109, 164);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(45, 22);
            this.lbl_Year.TabIndex = 9;
            this.lbl_Year.Text = "Year:";
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(169, 134);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Model.Properties.Appearance.Options.UseFont = true;
            this.txt_Model.Size = new System.Drawing.Size(268, 24);
            this.txt_Model.TabIndex = 3;
            // 
            // lbl_Model
            // 
            this.lbl_Model.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Appearance.Options.UseFont = true;
            this.lbl_Model.Location = new System.Drawing.Point(97, 136);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(57, 22);
            this.lbl_Model.TabIndex = 7;
            this.lbl_Model.Text = "Model:";
            // 
            // txt_SupplierCompany
            // 
            this.txt_SupplierCompany.Location = new System.Drawing.Point(169, 104);
            this.txt_SupplierCompany.Name = "txt_SupplierCompany";
            this.txt_SupplierCompany.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SupplierCompany.Properties.Appearance.Options.UseFont = true;
            this.txt_SupplierCompany.Size = new System.Drawing.Size(268, 24);
            this.txt_SupplierCompany.TabIndex = 2;
            // 
            // lbl_SupplierCompany
            // 
            this.lbl_SupplierCompany.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplierCompany.Appearance.Options.UseFont = true;
            this.lbl_SupplierCompany.Location = new System.Drawing.Point(2, 104);
            this.lbl_SupplierCompany.Name = "lbl_SupplierCompany";
            this.lbl_SupplierCompany.Size = new System.Drawing.Size(151, 22);
            this.lbl_SupplierCompany.TabIndex = 5;
            this.lbl_SupplierCompany.Text = "SupplierCompany:";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(169, 74);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ProductName.Properties.Appearance.Options.UseFont = true;
            this.txt_ProductName.Size = new System.Drawing.Size(268, 24);
            this.txt_ProductName.TabIndex = 1;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductName.Appearance.Options.UseFont = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(36, 77);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(118, 22);
            this.lbl_ProductName.TabIndex = 3;
            this.lbl_ProductName.Text = "ProductName:";
            // 
            // mskdtxt_Year
            // 
            this.mskdtxt_Year.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdtxt_Year.Location = new System.Drawing.Point(169, 164);
            this.mskdtxt_Year.Mask = "0000";
            this.mskdtxt_Year.Name = "mskdtxt_Year";
            this.mskdtxt_Year.Size = new System.Drawing.Size(268, 25);
            this.mskdtxt_Year.TabIndex = 4;
            this.mskdtxt_Year.ValidatingType = typeof(int);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(169, 44);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Id.Properties.Appearance.Options.UseFont = true;
            this.txt_Id.Size = new System.Drawing.Size(268, 24);
            this.txt_Id.TabIndex = 15;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Id.Appearance.Options.UseFont = true;
            this.lbl_Id.Location = new System.Drawing.Point(127, 46);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(36, 22);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID:  ";
            // 
            // Frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 561);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Products";
            this.Text = "PRODUCTS";
            this.Load += new System.EventHandler(this.Frm_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUD_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SupplierCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox mskdtxt_Year;
        private DevExpress.XtraEditors.TextEdit txt_Id;
        private DevExpress.XtraEditors.LabelControl lbl_Id;
        private DevExpress.XtraEditors.LabelControl lbl_Details;
        private DevExpress.XtraEditors.TextEdit txt_SalePrice;
        private DevExpress.XtraEditors.LabelControl lbl_Saleprice;
        private DevExpress.XtraEditors.TextEdit txt_PurchasePrice;
        private DevExpress.XtraEditors.LabelControl lbl_PurchasePrice;
        private DevExpress.XtraEditors.LabelControl lbl_Stok;
        private System.Windows.Forms.NumericUpDown nmrcUD_Stock;
        private DevExpress.XtraEditors.LabelControl lbl_Year;
        private DevExpress.XtraEditors.TextEdit txt_Model;
        private DevExpress.XtraEditors.LabelControl lbl_Model;
        private DevExpress.XtraEditors.TextEdit txt_SupplierCompany;
        private DevExpress.XtraEditors.LabelControl lbl_SupplierCompany;
        private DevExpress.XtraEditors.TextEdit txt_ProductName;
        private DevExpress.XtraEditors.LabelControl lbl_ProductName;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.RichTextBox richtxt_Details;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Clean;
    }
}