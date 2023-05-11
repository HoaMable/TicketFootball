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

namespace QuanLy
{
    public partial class UpadateTranDau : Form
    {
        string strConnectionString = @"Data Source=HOAPRO\SQLEXPRESS;Initial Catalog=UEFA_Ticket;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public UpadateTranDau()
        {
            InitializeComponent();
        }
        public void Load_KH()
        {
            da = new SqlDataAdapter("Select * from SoccerMatch", conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void Load_Combo()
        {
            da = new SqlDataAdapter("Select * from NameRoundd where NameRoundID >4", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbtenvong.DataSource = dt;
            cbtenvong.DisplayMember = "NameRound";
            cbtenvong.ValueMember = "NameRoundID";
        }
        private void UpadateTranDau_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            Load_KH();
            Load_Combo();
        }

        private void UpadateTranDau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat)
            Application.Exit();
        }
        bool isThoat =true;
        private void btntrove_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            DanhMucChinhSua a = new DanhMucChinhSua();
            a.Show();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Mã trận đấu không được bỏ trống");
            }
            else if (txttentran.Text == "")
            {
                MessageBox.Show("Tên trận đấu không được bỏ trống");
            }
            else if (txtshowtime.Text == "")
            {
                MessageBox.Show("Thời gian trận đấu không được bỏ trống");
            }
            else if (txtday.Text == "")
            {
                MessageBox.Show("Ngày trận đấu diễn ra không được bỏ trống");
            }
            else if (cbtenvong.Text == "")
            {
                MessageBox.Show("Tên vòng đấu không được bỏ trống");
            }
            else if (txttrongtai.Text == "")
            {
                MessageBox.Show("Tên trọng tài không được bỏ trống");
            }
            else if (txtsvd.Text == "")
            {
                MessageBox.Show("Tên sân vận động không được bỏ trống");
            }
            else if (txtgia.Text == "")
            {
                MessageBox.Show("Giá trận đấu không được bỏ trống");
            }else if (txttongve.Text == "")
            {
                MessageBox.Show("Tổng vé trận đấu không được bỏ trống");
            }
            else
            {
                try
                {
                    conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    String sql = "Insert SoccerMatch values('"
                        + txtma.Text + "','"
                        + txttentran.Text + "','" 
                        + txtshowtime.Text + "','"
                        + txtday.Text + "','"
                        + cbtenvong.SelectedValue + "','"
                        + txttrongtai.Text + "','"
                        + txtsvd.Text + "','"
                        + txtgia.Text + "','"
                        + txttongve.Text + "')";
                    DialogResult dlr = MessageBox.Show("Xác nhận thêm trận đấu ", "Thông báo", MessageBoxButtons.YesNo);
                    if (dlr == DialogResult.Yes)
                        cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    Load_KH();
                }
                catch
                {
                    MessageBox.Show("Mã không được trùng và vui lòng nhập lại ngày");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thoát !!",
"Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtma.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txttentran.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            txtshowtime.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            txtday.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            cbtenvong.SelectedValue = dataGridView1.Rows[dong].Cells[4].Value.ToString();
            txttrongtai.Text = dataGridView1.Rows[dong].Cells[5].Value.ToString();
            txtsvd.Text = dataGridView1.Rows[dong].Cells[6].Value.ToString();
            txtgia.Text = dataGridView1.Rows[dong].Cells[7].Value.ToString();
            txttongve.Text = dataGridView1.Rows[dong].Cells[8].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Mã trận đấu không được bỏ trống");
            }
            else if (txttentran.Text == "")
            {
                MessageBox.Show("Tên trận đấu không được bỏ trống");
            }
            else if (txtshowtime.Text == "")
            {
                MessageBox.Show("Thời gian trận đấu không được bỏ trống");
            }
            else if (txtday.Text == "")
            {
                MessageBox.Show("Ngày trận đấu diễn ra không được bỏ trống");
            }
            else if (cbtenvong.Text == "")
            {
                MessageBox.Show("Tên vòng đấu không được bỏ trống");
            }
            else if (txttrongtai.Text == "")
            {
                MessageBox.Show("Tên trọng tài không được bỏ trống");
            }
            else if (txtsvd.Text == "")
            {
                MessageBox.Show("Tên sân vận động không được bỏ trống");
            }
            else if (txtgia.Text == "")
            {
                MessageBox.Show("Giá trận đấu không được bỏ trống");
            }
            else
            {
                try
                {
                  
                    conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    String sql = "Update SoccerMatch set SoccerName='" + txttentran.Text +"'," + 
                        "Showtime='"+ txtshowtime.Text + "'," + 
                        "Day='" + txtday.Text +"'," + 
                        "NameRoundID='" + cbtenvong.SelectedValue +"'," + 
                        "NameReferee='" + txttrongtai.Text +"'," + 
                        "NameStadium='"  + txtsvd.Text +  "'," + 
                        "Price='" + txtgia.Text + "'," + 
                        "TotalTicket='" + txttongve.Text + "'" + "Where SoccerID='" + txtma.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    Load_KH();
                }
                catch
                {
                    MessageBox.Show("Mã không được trùng và vui lòng nhập lại ngày");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            String sql = "Delete from SoccerMatch where SoccerID='" + txtma.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn xoá không", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                Load_KH();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "")
            {
                MessageBox.Show("Mời bạn nhập từ khoá tìm kiếm");
            }
            else
            {
                conn = new SqlConnection(strConnectionString);
                string sql = "Select * from SoccerMatch where SoccerID='" + txttk.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn tìm không ", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                    dataGridView1.DataSource = dt;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtma.ResetText();
            txtma.Focus();
            txttentran.ResetText();
            txtshowtime.ResetText();
            txtday.ResetText();
            cbtenvong.ResetText();
            txttongve.ResetText();
            txttrongtai.ResetText();
            txtsvd.ResetText();
            txtgia.ResetText();
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
