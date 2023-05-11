using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Reservation_Football
{
    public partial class KetQuaTranDau : Form
    {
        public KetQuaTranDau()
        {
            InitializeComponent();
        }

        private void btntuketluondi_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var sp = from p in db.SoccerMatches
                     join k in db.ResultSoccers
                     on p.SoccerID equals k.SoccerID
                     join f in db.NameRoundds
                     on p.NameRoundID equals f.NameRoundID
                     where f.NameRound== "Vòng 1/8 lượt đi"
                     select new {k.STT, p.SoccerName, p.Showtime, p.Day, f.NameRound, p.NameStadium, k.Score };
            dataGridView1.DataSource = sp;
        }

        private void btntuketluotve_Click(object sender, EventArgs e)
        {

            dbDataContext db = new dbDataContext();
            var sp = from p in db.SoccerMatches
                     join k in db.ResultSoccers
                     on p.SoccerID equals k.SoccerID
                     join f in db.NameRoundds
                     on p.NameRoundID equals f.NameRoundID
                     where f.NameRound == "Vòng 1/8 lượt về"
                     select new { k.STT, p.SoccerName, p.Showtime, p.Day, f.NameRound, p.NameStadium, k.Score };
            dataGridView1.DataSource = sp;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thoát !!",
    "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }

        private void btnketqua_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var sp = from p in db.SoccerMatches
                     join k in db.ResultSoccerTotals
                     on p.SoccerID equals k.SoccerID
                     where k.NameRound == "Kết quả chung cuộc"
                     select new { p.SoccerName,k.NameRound, k.TotalResult };
            dataGridView1.DataSource = sp;
        }

        private void btndanhsach_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var sp = from p in db.Winners
                     join k in db.ResultSoccerTotals
                     on p.TotalID equals k.TotalID
                     where p.Total == "Winner"
                     select new {p.WinnerID ,p.SoccerName, p.NameCoach,p.Total ,k.TotalResult };
            dataGridView1.DataSource = sp;
        }
    }
}
