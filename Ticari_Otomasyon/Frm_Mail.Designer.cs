
namespace Ticari_Otomasyon
{
    partial class Frm_Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mail));
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_MailAddress = new DevExpress.XtraEditors.TextEdit();
            this.txt_Subject = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.rchtxt_Message = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Send = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MailAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Subject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(2, 310);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(128, 22);
            this.lbl_Mail.TabIndex = 5;
            this.lbl_Mail.Text = " Mail Address:";
            // 
            // txt_MailAddress
            // 
            this.txt_MailAddress.Location = new System.Drawing.Point(136, 309);
            this.txt_MailAddress.Name = "txt_MailAddress";
            this.txt_MailAddress.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MailAddress.Properties.Appearance.Options.UseFont = true;
            this.txt_MailAddress.Size = new System.Drawing.Size(391, 26);
            this.txt_MailAddress.TabIndex = 6;
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(136, 341);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.Properties.Appearance.Options.UseFont = true;
            this.txt_Subject.Size = new System.Drawing.Size(391, 26);
            this.txt_Subject.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject:";
            // 
            // rchtxt_Message
            // 
            this.rchtxt_Message.Location = new System.Drawing.Point(136, 373);
            this.rchtxt_Message.Name = "rchtxt_Message";
            this.rchtxt_Message.Size = new System.Drawing.Size(391, 306);
            this.rchtxt_Message.TabIndex = 9;
            this.rchtxt_Message.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Message:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 254);
            this.panel1.TabIndex = 11;
            // 
            // btn_Send
            // 
            this.btn_Send.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Send.Appearance.Options.UseFont = true;
            this.btn_Send.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Send.ImageOptions.SvgImage")));
            this.btn_Send.Location = new System.Drawing.Point(303, 685);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(224, 36);
            this.btn_Send.TabIndex = 12;
            this.btn_Send.Text = "Send";
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(131, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "MAIL SENDING PANEL ";
            // 
            // Frm_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(539, 730);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchtxt_Message);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MailAddress);
            this.Controls.Add(this.lbl_Mail);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIL";
            this.Load += new System.EventHandler(this.Frm_Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MailAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Subject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Mail;
        private DevExpress.XtraEditors.TextEdit txt_MailAddress;
        private DevExpress.XtraEditors.TextEdit txt_Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchtxt_Message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Send;
        private System.Windows.Forms.Label label3;
    }
}