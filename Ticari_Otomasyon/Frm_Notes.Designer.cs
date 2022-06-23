
namespace Ticari_Otomasyon
{
    partial class Frm_Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notes));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Grdcntrl_Notes = new DevExpress.XtraGrid.GridControl();
            this.msktxb_Clock = new System.Windows.Forms.MaskedTextBox();
            this.msktxb_Date = new System.Windows.Forms.MaskedTextBox();
            this.grpcntrl_Customers = new DevExpress.XtraEditors.GroupControl();
            this.btn_Clean = new DevExpress.XtraEditors.SimpleButton();
            this.rch_detail = new System.Windows.Forms.RichTextBox();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Notetitle = new DevExpress.XtraEditors.TextEdit();
            this.lbl_PurchasePrice = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Stok = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Year = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Model = new DevExpress.XtraEditors.LabelControl();
            this.txt_NoteHitap = new DevExpress.XtraEditors.TextEdit();
            this.lbl_SupplierCompany = new DevExpress.XtraEditors.LabelControl();
            this.txt_NoteMaker = new DevExpress.XtraEditors.TextEdit();
            this.lbl_ProductName = new DevExpress.XtraEditors.LabelControl();
            this.txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Id = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcntrl_Notes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcntrl_Customers)).BeginInit();
            this.grpcntrl_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Notetitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NoteHitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NoteMaker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.LightCoral;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.Grdcntrl_Notes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Grdcntrl_Notes
            // 
            this.Grdcntrl_Notes.Location = new System.Drawing.Point(1, 0);
            this.Grdcntrl_Notes.MainView = this.gridView1;
            this.Grdcntrl_Notes.Name = "Grdcntrl_Notes";
            this.Grdcntrl_Notes.Size = new System.Drawing.Size(1064, 560);
            this.Grdcntrl_Notes.TabIndex = 4;
            this.Grdcntrl_Notes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // msktxb_Clock
            // 
            this.msktxb_Clock.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_Clock.Location = new System.Drawing.Point(169, 106);
            this.msktxb_Clock.Mask = "00:00";
            this.msktxb_Clock.Name = "msktxb_Clock";
            this.msktxb_Clock.Size = new System.Drawing.Size(268, 25);
            this.msktxb_Clock.TabIndex = 30;
            this.msktxb_Clock.ValidatingType = typeof(System.DateTime);
            // 
            // msktxb_Date
            // 
            this.msktxb_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktxb_Date.Location = new System.Drawing.Point(169, 74);
            this.msktxb_Date.Mask = "00/00/0000";
            this.msktxb_Date.Name = "msktxb_Date";
            this.msktxb_Date.Size = new System.Drawing.Size(268, 25);
            this.msktxb_Date.TabIndex = 29;
            this.msktxb_Date.ValidatingType = typeof(System.DateTime);
            // 
            // grpcntrl_Customers
            // 
            this.grpcntrl_Customers.Controls.Add(this.btn_Clean);
            this.grpcntrl_Customers.Controls.Add(this.rch_detail);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_Clock);
            this.grpcntrl_Customers.Controls.Add(this.msktxb_Date);
            this.grpcntrl_Customers.Controls.Add(this.btn_Update);
            this.grpcntrl_Customers.Controls.Add(this.btn_Delete);
            this.grpcntrl_Customers.Controls.Add(this.btn_Save);
            this.grpcntrl_Customers.Controls.Add(this.txt_Notetitle);
            this.grpcntrl_Customers.Controls.Add(this.lbl_PurchasePrice);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Stok);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Year);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Model);
            this.grpcntrl_Customers.Controls.Add(this.txt_NoteHitap);
            this.grpcntrl_Customers.Controls.Add(this.lbl_SupplierCompany);
            this.grpcntrl_Customers.Controls.Add(this.txt_NoteMaker);
            this.grpcntrl_Customers.Controls.Add(this.lbl_ProductName);
            this.grpcntrl_Customers.Controls.Add(this.txt_Id);
            this.grpcntrl_Customers.Controls.Add(this.lbl_Id);
            this.grpcntrl_Customers.Location = new System.Drawing.Point(1071, 0);
            this.grpcntrl_Customers.Name = "grpcntrl_Customers";
            this.grpcntrl_Customers.Size = new System.Drawing.Size(456, 560);
            this.grpcntrl_Customers.TabIndex = 5;
            this.grpcntrl_Customers.Text = " ";
            // 
            // btn_Clean
            // 
            this.btn_Clean.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clean.Appearance.Options.UseFont = true;
            this.btn_Clean.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Clean.ImageOptions.SvgImage")));
            this.btn_Clean.Location = new System.Drawing.Point(169, 484);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(268, 44);
            this.btn_Clean.TabIndex = 32;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // rch_detail
            // 
            this.rch_detail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rch_detail.Location = new System.Drawing.Point(169, 227);
            this.rch_detail.Name = "rch_detail";
            this.rch_detail.Size = new System.Drawing.Size(268, 100);
            this.rch_detail.TabIndex = 31;
            this.rch_detail.Text = "";
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Update.ImageOptions.SvgImage")));
            this.btn_Update.Location = new System.Drawing.Point(169, 434);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(268, 44);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Update";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Delete.ImageOptions.SvgImage")));
            this.btn_Delete.Location = new System.Drawing.Point(169, 384);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(268, 44);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Save.ImageOptions.SvgImage")));
            this.btn_Save.Location = new System.Drawing.Point(169, 334);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(268, 44);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Notetitle
            // 
            this.txt_Notetitle.Location = new System.Drawing.Point(169, 137);
            this.txt_Notetitle.Name = "txt_Notetitle";
            this.txt_Notetitle.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Notetitle.Properties.Appearance.Options.UseFont = true;
            this.txt_Notetitle.Size = new System.Drawing.Size(268, 24);
            this.txt_Notetitle.TabIndex = 13;
            // 
            // lbl_PurchasePrice
            // 
            this.lbl_PurchasePrice.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PurchasePrice.Appearance.Options.UseFont = true;
            this.lbl_PurchasePrice.Location = new System.Drawing.Point(74, 195);
            this.lbl_PurchasePrice.Name = "lbl_PurchasePrice";
            this.lbl_PurchasePrice.Size = new System.Drawing.Size(89, 22);
            this.lbl_PurchasePrice.TabIndex = 12;
            this.lbl_PurchasePrice.Text = "NoteHitap:";
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stok.Appearance.Options.UseFont = true;
            this.lbl_Stok.Location = new System.Drawing.Point(63, 167);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(100, 22);
            this.lbl_Stok.TabIndex = 11;
            this.lbl_Stok.Text = "NoteMaker:";
            // 
            // lbl_Year
            // 
            this.lbl_Year.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Appearance.Options.UseFont = true;
            this.lbl_Year.Location = new System.Drawing.Point(70, 227);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(93, 22);
            this.lbl_Year.TabIndex = 9;
            this.lbl_Year.Text = "NoteDetail:";
            // 
            // lbl_Model
            // 
            this.lbl_Model.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Appearance.Options.UseFont = true;
            this.lbl_Model.Location = new System.Drawing.Point(81, 139);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(82, 22);
            this.lbl_Model.TabIndex = 7;
            this.lbl_Model.Text = "NoteTitle:";
            // 
            // txt_NoteHitap
            // 
            this.txt_NoteHitap.Location = new System.Drawing.Point(169, 197);
            this.txt_NoteHitap.Name = "txt_NoteHitap";
            this.txt_NoteHitap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_NoteHitap.Properties.Appearance.Options.UseFont = true;
            this.txt_NoteHitap.Size = new System.Drawing.Size(268, 24);
            this.txt_NoteHitap.TabIndex = 6;
            // 
            // lbl_SupplierCompany
            // 
            this.lbl_SupplierCompany.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplierCompany.Appearance.Options.UseFont = true;
            this.lbl_SupplierCompany.Location = new System.Drawing.Point(70, 109);
            this.lbl_SupplierCompany.Name = "lbl_SupplierCompany";
            this.lbl_SupplierCompany.Size = new System.Drawing.Size(93, 22);
            this.lbl_SupplierCompany.TabIndex = 5;
            this.lbl_SupplierCompany.Text = "NoteClock:";
            // 
            // txt_NoteMaker
            // 
            this.txt_NoteMaker.Location = new System.Drawing.Point(169, 167);
            this.txt_NoteMaker.Name = "txt_NoteMaker";
            this.txt_NoteMaker.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_NoteMaker.Properties.Appearance.Options.UseFont = true;
            this.txt_NoteMaker.Size = new System.Drawing.Size(268, 24);
            this.txt_NoteMaker.TabIndex = 4;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProductName.Appearance.Options.UseFont = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(80, 77);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(83, 22);
            this.lbl_ProductName.TabIndex = 3;
            this.lbl_ProductName.Text = "NoteDate:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(169, 44);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Id.Properties.Appearance.Options.UseFont = true;
            this.txt_Id.Size = new System.Drawing.Size(268, 24);
            this.txt_Id.TabIndex = 1;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Id.Appearance.Options.UseFont = true;
            this.lbl_Id.Location = new System.Drawing.Point(102, 44);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(61, 22);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "NoteId:";
            // 
            // Frm_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 561);
            this.Controls.Add(this.grpcntrl_Customers);
            this.Controls.Add(this.Grdcntrl_Notes);
            this.Name = "Frm_Notes";
            this.Text = "NOTES";
            this.Load += new System.EventHandler(this.Frm_Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcntrl_Notes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpcntrl_Customers)).EndInit();
            this.grpcntrl_Customers.ResumeLayout(false);
            this.grpcntrl_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Notetitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NoteHitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NoteMaker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl Grdcntrl_Notes;
        private System.Windows.Forms.MaskedTextBox msktxb_Clock;
        private System.Windows.Forms.MaskedTextBox msktxb_Date;
        private DevExpress.XtraEditors.GroupControl grpcntrl_Customers;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit txt_Notetitle;
        private DevExpress.XtraEditors.LabelControl lbl_PurchasePrice;
        private DevExpress.XtraEditors.LabelControl lbl_Stok;
        private DevExpress.XtraEditors.LabelControl lbl_Year;
        private DevExpress.XtraEditors.LabelControl lbl_Model;
        private DevExpress.XtraEditors.TextEdit txt_NoteHitap;
        private DevExpress.XtraEditors.LabelControl lbl_SupplierCompany;
        private DevExpress.XtraEditors.TextEdit txt_NoteMaker;
        private DevExpress.XtraEditors.LabelControl lbl_ProductName;
        private DevExpress.XtraEditors.TextEdit txt_Id;
        private DevExpress.XtraEditors.LabelControl lbl_Id;
        private System.Windows.Forms.RichTextBox rch_detail;
        private DevExpress.XtraEditors.SimpleButton btn_Clean;
    }
}