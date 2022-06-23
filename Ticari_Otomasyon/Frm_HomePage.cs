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
using System.Xml;

namespace Ticari_Otomasyon
{
    public partial class Frm_HomePage : Form
    {
        public Frm_HomePage()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();

        void Stocks()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter(
                    "Select ProductName,SUM(Stock) as Stock from Products  group by ProductName having SUM(Stock)<=30",
                    connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        void Agenda()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("Select top 15 NoteDate,NoteClock,NoteTitle from Notes  order by NoteId desc",
                    connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl2.DataSource = dataTable;
        }

        void CompanyMotion()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Exec CompanyMotion2", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl3.DataSource = dataTable;
        }

        void Catalog()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter =
                new SqlDataAdapter("Select CompanyName,Phone1 from Companies", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            gridControl4.DataSource = dataTable;
        }

        void News()
        {
            XmlTextReader xmlTextReader = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlTextReader.Read())
            {
                if (xmlTextReader.Name == "title")
                {
                    listBox1.Items.Add(xmlTextReader.ReadString());
                }
            }
        }
        private void Frm_HomePage_Load(object sender, EventArgs e)
        {
            Stocks();
            Agenda();
            CompanyMotion();
            Catalog();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            News();
           // webBrowser2.Navigate("https://www.google.com/");
           // webBrowser3.Navigate("https://translate.google.com/");
           // webBrowser4.Navigate("https://mail.google.com/");
           // webBrowser5.Navigate("https://www.youtube.com/");
            
        }
    }
}
