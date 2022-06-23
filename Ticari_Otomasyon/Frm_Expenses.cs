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
    public partial class Frm_Expenses : Form
    {
        public Frm_Expenses()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();

        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Expenses", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Expenses.DataSource = dataTable;

        }

        void Clean()
        {
            txt_Id.Text = "";
            txt_ElectricInvoice.Text = "";
            txt_Extra.Text = "";
            txt_InternetInvoice.Text = "";
            txt_NaturalGazInvoice.Text = "";
            txt_Salaries.Text = "";
            txt_WaterInvoice.Text = "";
            cmbbx_Year.Text = "";
            cmbbx_Month.Text = "";
            rch_Notes.Text = "";

        }
        private void Frm_Expenses_Load(object sender, EventArgs e)
        {
            List();
            Clean();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "insert into Expenses (Month,Year,ElectricInvoice,WaterInvoice,NaturalGazInvoice,InternetInvoice,Salaries,Extra,Notes) values " +
                "(@Month,@Year,@ElectricInvoice,@WaterInvoice,@NaturalGazInvoice,@InternetInvoice,@Salaries,@Extra,@Notes)",
                connection.Connection());

            command.Parameters.AddWithValue("@Month", cmbbx_Month.Text);
            command.Parameters.AddWithValue("@Year", cmbbx_Year.Text);
            command.Parameters.AddWithValue("@ElectricInvoice", decimal.Parse(txt_ElectricInvoice.Text));
            command.Parameters.AddWithValue("@WaterInvoice", decimal.Parse(txt_WaterInvoice.Text));
            command.Parameters.AddWithValue("@NaturalGazInvoice", decimal.Parse(txt_NaturalGazInvoice.Text));
            command.Parameters.AddWithValue("@InternetInvoice", decimal.Parse(txt_InternetInvoice.Text));
            command.Parameters.AddWithValue("@Salaries", decimal.Parse(txt_Salaries.Text));
            command.Parameters.AddWithValue("@Extra", decimal.Parse(txt_Extra.Text));
            command.Parameters.AddWithValue("@Notes", rch_Notes.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Gider tabloya eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                txt_Id.Text = dataRow["Id"].ToString();
                cmbbx_Month.Text = dataRow["Month"].ToString();
                cmbbx_Year.Text = dataRow["Year"].ToString();
                txt_ElectricInvoice.Text = dataRow["ElectricInvoice"].ToString();
                txt_WaterInvoice.Text = dataRow["WaterInvoice"].ToString();
                txt_NaturalGazInvoice.Text = dataRow["NaturalGazInvoice"].ToString();
                txt_InternetInvoice.Text = dataRow["InternetInvoice"].ToString();
                txt_Salaries.Text = dataRow["Salaries"].ToString();
                txt_Extra.Text = dataRow["Extra"].ToString();
                rch_Notes.Text = dataRow["Notes"].ToString();
            }


        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void brn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Expenses where Id=@Id", connection.Connection());
            command.Parameters.AddWithValue("@Id", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Gider tablodan silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
            Clean();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "update Expenses set Month=@Month,Year=@Year,ElectricInvoice=@ElectricInvoice,WaterInvoice=@WaterInvoice,NaturalGazInvoice=@NaturalGazInvoice," +
                "InternetInvoice=@InternetInvoice,Salaries=@Salaries,Extra=@Extra,Notes=@Notes where Id=@Id",
                connection.Connection());

            command.Parameters.AddWithValue("@Month", cmbbx_Month.Text);
            command.Parameters.AddWithValue("@Year", cmbbx_Year.Text);
            command.Parameters.AddWithValue("@ElectricInvoice", decimal.Parse(txt_ElectricInvoice.Text));
            command.Parameters.AddWithValue("@WaterInvoice", decimal.Parse(txt_WaterInvoice.Text));
            command.Parameters.AddWithValue("@NaturalGazInvoice", decimal.Parse(txt_NaturalGazInvoice.Text));
            command.Parameters.AddWithValue("@InternetInvoice", decimal.Parse(txt_InternetInvoice.Text));
            command.Parameters.AddWithValue("@Salaries", decimal.Parse(txt_Salaries.Text));
            command.Parameters.AddWithValue("@Extra", decimal.Parse(txt_Extra.Text));
            command.Parameters.AddWithValue("@Notes", rch_Notes.Text);
            command.Parameters.AddWithValue("@Id", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Gider güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();
        }
    }
}
