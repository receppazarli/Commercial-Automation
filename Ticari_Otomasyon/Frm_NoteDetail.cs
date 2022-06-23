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
    public partial class Frm_NoteDetail : Form
    {
        public Frm_NoteDetail()
        {
            InitializeComponent();
        }

        public string text;
        private void Frm_NoteDetail_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = text; 
        }
    }
}
