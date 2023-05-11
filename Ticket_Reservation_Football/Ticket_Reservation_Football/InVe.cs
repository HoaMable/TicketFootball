using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ticket_Reservation_Football
{
    public partial class InVe : Form
    {
        string strConnectionString = @"Data Source=HOAPRO\SQLEXPRESS;Initial Catalog=UEFA_Ticket;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public InVe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Mời nhập mã để in hoá đơn");
            }
            else
            {
                conn = new SqlConnection(strConnectionString);
                DataTable dt = new DataTable();

                da = new SqlDataAdapter("select a.CustomerID,Names,SoccerName,Day,Showtime,d.NameRound,NameStadium,Quantity,Price*Quantity[Total] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID join Customer c on a.CustomerID=c.CustomerID join NameRoundd d on d.NameRoundID=b.NameRoundID where a.CustomerID='" + textBox1.Text + "'", conn);
                dt = new DataTable();
                da.Fill(dt);
                CrystalReport1 phim = new CrystalReport1();
                phim.SetDataSource(dt);
                crystalReportViewer1.ReportSource = phim;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thoát !!",
               "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }
    }
}
