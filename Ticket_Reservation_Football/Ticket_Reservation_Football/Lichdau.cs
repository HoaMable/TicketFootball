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
    public partial class Lichdau : Form
    {
        public Lichdau()
        {
            InitializeComponent();
        }

        private void btntuketluotdi_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var sp = from p in db.SoccerMatches
                     join k in db.NameRoundds
                     on p.NameRoundID equals k.NameRoundID
                     where k.NameRound == "Tứ kết lượt đi"
                     select new { p.SoccerID, p.SoccerName, p.Showtime, p.Day, k.NameRound, p.NameReferee, p.NameStadium };
            dataGridView1.DataSource = sp;
        }

        private void btntuketluotve_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var sp = from p in db.SoccerMatches
                     join k in db.NameRoundds
                     on p.NameRoundID equals k.NameRoundID
                     where k.NameRound == "Tứ kết lượt về"
                     select new { p.SoccerID, p.SoccerName, p.Showtime, p.Day, k.NameRound, p.NameReferee, p.NameStadium };
            dataGridView1.DataSource = sp;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thoát !!",
    "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }
    }
}
