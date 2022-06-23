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
    public partial class Frm_Notes : Form
    {
        public Frm_Notes()
        {
            InitializeComponent();
        }

        private Sql_Connection connection = new Sql_Connection();

        void List()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Notes", connection.Connection());
            sqlDataAdapter.Fill(dataTable);
            Grdcntrl_Notes.DataSource = dataTable;

        }

        void Clean()
        {
            txt_Id.Text = "";
            msktxb_Date.Text = "";
            msktxb_Clock.Text = "";
            txt_Notetitle.Text = "";
            txt_NoteMaker.Text = "";
            txt_NoteHitap.Text = "";
            rch_detail.Text = "";
        }
        private void Frm_Notes_Load(object sender, EventArgs e)
        {
            List();
            Clean();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "insert into Notes (NoteDate,NoteClock,NoteTitle,NoteMaker,NoteHitap,NoteDetail) values" +
                "(@NoteDate,@NoteClock,@NoteTitle,@NoteMaker,@NoteHitap,@NoteDetail)", connection.Connection());

            command.Parameters.AddWithValue("@NoteDate", msktxb_Date.Text);
            command.Parameters.AddWithValue("@NoteClock", msktxb_Clock.Text);
            command.Parameters.AddWithValue("@NoteTitle", txt_Notetitle.Text);
            command.Parameters.AddWithValue("@NoteMaker", txt_NoteMaker.Text);
            command.Parameters.AddWithValue("@NoteHitap", txt_NoteHitap.Text);
            command.Parameters.AddWithValue("@NoteDetail", rch_detail.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Notes sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();
            Clean();
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                txt_Id.Text = dataRow["NoteId"].ToString();
                msktxb_Date.Text = dataRow["NoteDate"].ToString();
                msktxb_Clock.Text = dataRow["NoteClock"].ToString();
                txt_Notetitle.Text = dataRow["NoteTitle"].ToString();
                txt_NoteMaker.Text = dataRow["NoteMaker"].ToString();
                txt_NoteHitap.Text = dataRow["NoteHitap"].ToString();
                rch_detail.Text = dataRow["NoteDetail"].ToString();

            }
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Notes where NoteId=@NoteId", connection.Connection());
            command.Parameters.AddWithValue("@NoteId", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Note sistemden silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            List();
            Clean();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand command =
                new SqlCommand(
                    "Update Notes set  NoteDate=@NoteDate,NoteClock=@NoteClock,NoteTitle=@NoteTitle,NoteMaker=@NoteMaker,NoteHitap=@NoteHitap,NoteDetail=@NoteDetail where NoteId=@NoteId",
                    connection.Connection());

            command.Parameters.AddWithValue("@NoteDate", msktxb_Date.Text);
            command.Parameters.AddWithValue("@NoteClock", msktxb_Clock.Text);
            command.Parameters.AddWithValue("@NoteTitle", txt_Notetitle.Text);
            command.Parameters.AddWithValue("@NoteMaker", txt_NoteMaker.Text);
            command.Parameters.AddWithValue("@NoteHitap", txt_NoteHitap.Text);
            command.Parameters.AddWithValue("@NoteDetail", rch_detail.Text);
            command.Parameters.AddWithValue("@NoteId", txt_Id.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Notes bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            List();
            Clean();


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_NoteDetail frmNoteDetail = new Frm_NoteDetail();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                frmNoteDetail.text = dataRow["NoteDetail"].ToString();
            }
            frmNoteDetail.Show();
        }
    }
}
