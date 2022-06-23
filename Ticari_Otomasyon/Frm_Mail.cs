using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Frm_Mail : Form
    {
        public Frm_Mail()
        {
            InitializeComponent();
        }

        public string mail;
        private void Frm_Mail_Load(object sender, EventArgs e)
        {
            txt_MailAddress.Text = mail; 
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            MailMessage myMessage = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("asdasasdas776@gmail.com", "Asdas.123");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
           // myMessage.To.Add(rchtxt_Message.Text);
            myMessage.To.Add(txt_MailAddress.Text);
            myMessage.From = new MailAddress("asdasasdas776@gmail.com");
            myMessage.Subject = txt_Subject.Text;
            myMessage.Body = rchtxt_Message.Text;
            client.Send(myMessage);
        }
    }
}
