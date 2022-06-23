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
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();
        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            btn_Login.BackColor=Color.Aquamarine;
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.Crimson;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Admin where UserName=@UserName and Password=@Password",
                connection.Connection());
            command.Parameters.AddWithValue("@UserName", txt_UserName.Text);
            command.Parameters.AddWithValue("Password", txt_Password.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                Frm_AnaModul form1 = new Frm_AnaModul();
                form1.user = txt_UserName.Text;
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Connection().Close();
        }

        private void Frm_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
