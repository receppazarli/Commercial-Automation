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
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
    public partial class Frm_Safe : Form
    {
        public Frm_Safe()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();


        void CustomerMotion()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Execute CustomerMotion", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Customer.DataSource = dataTable;
        }

        void CompanyMotion()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Execute CompanyMotion", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Company.DataSource = dataTable;
        }

        void TotalAmount()
        {
            // toplam tutarı hesaplama
            SqlCommand command = new SqlCommand("Select Sum(Tutar) from InvoiceDetail", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_TotalAmount.Text = sqlDataReader[0].ToString() + " ₺";
            }
            connection.Connection().Close();
        }

        void Payments()
        {
            // son ayın faturaları
            SqlCommand command =
                new SqlCommand(
                    "Select (ElectricInvoice+WaterInvoice+NaturalGazInvoice+InternetInvoice+Extra) from Expenses order by Id",
                    connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_Payments.Text = sqlDataReader[0].ToString() + " ₺";
            }
            connection.Connection().Close();
        }

        void StaffSalary()
        {
            // son ayın personel maaşları   
            SqlCommand command = new SqlCommand("Select Salaries from Expenses order by Id", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_StaffSalary.Text = sqlDataReader[0].ToString() + " ₺";
            }
            connection.Connection().Close();
        }

        void Customer()
        {
            // Toplam müşteri sayısı
            SqlCommand command = new SqlCommand("Select Count(*) from Customers", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_Customer.Text = sqlDataReader[0].ToString();
            }
            connection.Connection().Close();
        }

        void Company()
        {
            // Toplam firma sayısı                  
            SqlCommand command = new SqlCommand("Select Count(*) from Companies", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_Company.Text = sqlDataReader[0].ToString();
            }
            connection.Connection().Close();
        }

        void CompanyCity()
        {
            // Toplam firma şehir sayısı                  
            SqlCommand command = new SqlCommand("Select Count(distinct(City)) from Companies", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_CityCompany.Text = sqlDataReader[0].ToString();
            }
            connection.Connection().Close();
        }

        void CustomerCity()
        {
            // Toplam müşteri şehir sayısı
            SqlCommand command = new SqlCommand("Select Count(distinct(City)) from Customers", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_CityCustomers.Text = sqlDataReader[0].ToString();
            }
            connection.Connection().Close();
        }

        void Staff()
        {
            // Toplam personel sayısı
            SqlCommand command = new SqlCommand("Select Count(*) from Personnels", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_Staff.Text = sqlDataReader[0].ToString();
            }
            connection.Connection().Close();
        }

        void Stock()
        {
            // Toplam stok sayısı
            SqlCommand command = new SqlCommand("Select sum(Stock) from Products", connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_Stock.Text = sqlDataReader[0].ToString();
            }
            connection.Connection().Close();
        }

        void chart1()
        {
            //  son 4 ayın ekstra faturasını listeleme.
            chartControl1.Series["MONTHS"].Points.Clear();
            groupControl9.Text = "Electric Invoices";
            SqlCommand command = new SqlCommand("select top 4 Month,ElectricInvoice from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl1.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection();
        }

        void chart2()
        {
            //  son 4 ayın su faturasını listeleme.
            chartControl1.Series["MONTHS"].Points.Clear();
            groupControl9.Text = "Water Invoices";

            SqlCommand command = new SqlCommand("select top 4 Month,WaterInvoice from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl1.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection().Close();
        }

        void chart3()
        {
            //  son 4 ayın doğalgaz faturasını listeleme.
            chartControl1.Series["MONTHS"].Points.Clear();
            groupControl9.Text = "Natural Gaz Invoices";

            SqlCommand command = new SqlCommand("select top 4 Month,NaturalGazInvoice from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl1.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection().Close();
        }

        void chart4()
        {
            //  son 4 ayın internet faturasını listeleme.
            chartControl1.Series["MONTHS"].Points.Clear();
            groupControl9.Text = "Internet Invoices";

            SqlCommand command = new SqlCommand("select top 4 Month,InternetInvoice from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl1.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection().Close();
        }

        void chart5()
        {
            //  son 4 ayın internet faturasını listeleme.
            chartControl1.Series["MONTHS"].Points.Clear();
            groupControl9.Text = "Extras";

            SqlCommand command = new SqlCommand("select top 4 Month,Extra from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl1.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection().Close();
        }

        void chart6()
        {
            //  son 4 ayın ekstra faturasını listeleme.
            chartControl2.Series["MONTHS"].Points.Clear();
            groupControl12.Text = "Electric Invoices";
            SqlCommand command = new SqlCommand("select top 4 Month,ElectricInvoice from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl2.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection();
        }

        void chart7()
        {
            //  son 4 ayın su faturasını listeleme.
            chartControl2.Series["MONTHS"].Points.Clear();
            groupControl12.Text = "Water Invoices";

            SqlCommand command = new SqlCommand("select top 4 Month,WaterInvoice from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl2.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection().Close();
        }

        void chart8()
        {
            //  son 4 ayın doğalgaz faturasını listeleme.
            chartControl2.Series["MONTHS"].Points.Clear();
            groupControl12.Text = "Natural Gaz Invoices";

            SqlCommand command = new SqlCommand("select top 4 Month,NaturalGazInvoice from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl2.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection().Close();
        }

        void chart9()
        {
            //  son 4 ayın internet faturasını listeleme.
            chartControl2.Series["MONTHS"].Points.Clear();
            groupControl12.Text = "Internet Invoices";

            SqlCommand command = new SqlCommand("select top 4 Month,InternetInvoice from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl2.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection().Close();
        }

        void chart10()
        {
            //  son 4 ayın internet faturasını listeleme.
            chartControl2.Series["MONTHS"].Points.Clear();
            groupControl12.Text = "Extras";

            SqlCommand command = new SqlCommand("select top 4 Month,Extra from Expenses  order by Id desc",
                connection.Connection());
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                chartControl2.Series["MONTHS"].Points
                    .Add(new DevExpress.XtraCharts.SeriesPoint(sqlDataReader[0], sqlDataReader[1]));
            }

            connection.Connection().Close();
        }

        void InvoiceMotion()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Expenses ", connection.Connection());
            sqlDataAdapter.Fill(dataTable);   // dataadapterın içini data tableyla doldur
            Grdcntrl_Exit.DataSource = dataTable;
        }


        public string name;
        private void Frm_Safe_Load(object sender, EventArgs e)
        {
            lbl_ActiveUser.Text = name;
            CustomerMotion();
            CompanyMotion();
            InvoiceMotion();
            TotalAmount();
            Payments();
            StaffSalary();
            Customer();
            Company();
            CompanyCity();
            CustomerCity();
            Staff();
            Stock();

        }

        private int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                chart1();
            }

            else if (sayac > 5 && sayac <= 10)
            {
                chart2();
            }

            else if (sayac > 10 && sayac <= 15)
            {
                chart3();
            }

            else if (sayac > 15 && sayac <= 20)
            {
                chart4();
            }

            else if (sayac > 20 && sayac <= 25)
            {
                chart5();
            }

            else if (sayac == 26)
            {
                sayac = 0;
            }
            else
            {
                sayac = 0;
            }
        }

        private int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 10)
            {
                chart6();
            }

            else if (sayac2 > 10 && sayac2 <= 20)
            {
                chart7();
            }

            else if (sayac2 > 20 && sayac2 <= 30)
            {
                chart8();
            }

            else if (sayac2 > 30 && sayac2 <= 40)
            {
                chart9();
            }

            else if (sayac2 > 40 && sayac2 <= 50)
            {
                chart10();
            }

            else if (sayac == 51)
            {
                sayac2 = 0;
            }
            else
            {
                sayac2 = 0;
            }
        }
    }
}
