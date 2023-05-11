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
    public partial class Datve : Form
    {
        string strConnectionString = @"Data Source=HOAPRO\SQLEXPRESS;Initial Catalog=UEFA_Ticket;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public Datve()
        {
            InitializeComponent();
        }
        public void Load_SP()
        {

            da = new SqlDataAdapter(" select a.CustomerID,Names,SoccerName,Day,Showtime,d.NameRound,NameStadium,Quantity,Price*Quantity[Total] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID join Customer c on a.CustomerID=c.CustomerID join NameRoundd d on d.NameRoundID=b.NameRoundID where a.CustomerID='" + txtmakh.Text + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
       
        }

        void LoadComboVong()
        {
            da = new SqlDataAdapter("select * from NameRoundd where NameRoundID=3 or NameRoundID=4 ", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbvongdau.DataSource = dt;
            cbvongdau.DisplayMember = "NameRound";
            cbvongdau.ValueMember = "NameRoundID";
        }
        void LoadCombo()
        {
            LoadComboVong();
            da = new SqlDataAdapter("Select * from  SoccerMatch where NameRoundID='" + cbvongdau.SelectedValue + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbtranxem.DataSource = dt;
            cbtranxem.DisplayMember = "SoccerName";
            cbtranxem.ValueMember = "SoccerID";



        }
        private void Datve_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            LoadCombo();
            LoadComboVong();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * from  SoccerMatch where NameRoundID='" + cbvongdau.SelectedValue + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbtranxem.DataSource = dt;
            cbtranxem.DisplayMember = "SoccerName";
            cbtranxem.ValueMember = "SoccerID";
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmakh.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            cbtranxem.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            cbvongdau.Text = dataGridView1.Rows[dong].Cells[5].Value.ToString();
            txtsld.Text = dataGridView1.Rows[dong].Cells[7].Value.ToString();
        }

        private void btndatve_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng");
            }
            else if (cbvongdau.Text == "")
            {
                MessageBox.Show("Vui lòng chọn vòng đấu muốn xem");
            }
            else if (cbtranxem.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trận đấu muốn xem");
            }
            else if (txtsld.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng vé muốn đặt");
            }
            else
            {        
                    conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    String sql = "Insert Tickets values('" + txtmakh.Text + "','"
                        + cbvongdau.SelectedValue + "','" + cbtranxem.SelectedValue + "','" + txtsld.Text + "')";
                    DialogResult dlr = MessageBox.Show("Xác nhận đặt vé ", "Thông báo", MessageBoxButtons.YesNo);
                    if (dlr == DialogResult.Yes)
                        cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                    Load_SP();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thoát !!",
                  "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng");
            }
            else if (cbvongdau.Text == "")
            {
                MessageBox.Show("Vui lòng chọn vòng đấu muốn xem");
            }
            else if (cbtranxem.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trận đấu muốn xem");
            }
            else if (txtsld.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng vé muốn đặt");
            }
            else
            {
                conn = new SqlConnection(strConnectionString);
                conn.Open();
                String sql = "Update Tickets set NameRoundID='" + cbvongdau.SelectedValue + "'," +
                    "SoccerID='" + cbtranxem.SelectedValue + "'," +
                    "Quantity='" + txtsld.Text + "'" +
                     "Where CustomerID='" + txtmakh.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                Load_SP();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtmakh.ResetText();
            cbtranxem.ResetText();
            cbvongdau.ResetText();
            txtsld.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            String sql = "Delete from Tickets where CustomerID='" + txtmakh.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn xoá không", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                Load_SP();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã của khách hàng");
            }
            else
            {
                string sql = " select a.CustomerID,Names,SoccerName,Day,Showtime,d.NameRound,NameStadium,Quantity,Price*Quantity[Total] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID join Customer c on a.CustomerID=c.CustomerID join NameRoundd d on d.NameRoundID=b.NameRoundID where a.CustomerID='" + txttimkiem.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn tìm không ", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                    dataGridView1.DataSource = dt;
            }
        }
    }
}
