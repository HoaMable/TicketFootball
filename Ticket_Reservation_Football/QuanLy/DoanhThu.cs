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
    public partial class DoanhThu : Form
    {
        string strConnectionString = @"Data Source=HOAPRO\SQLEXPRESS;Initial Catalog=UEFA_Ticket;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public DoanhThu()
        {
            InitializeComponent();
        }
        void LoadComboVong()
        {
            da = new SqlDataAdapter("select * from NameRoundd where NameRoundID=3 or NameRoundID=4 ", conn);
            dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "NameRound";
            comboBox2.ValueMember = "NameRoundID";
        }
        void LoadCombo()
        {
            LoadComboVong();
            da = new SqlDataAdapter("Select * from  SoccerMatch where NameRoundID='" + comboBox2.SelectedValue + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SoccerName";
            comboBox1.ValueMember = "SoccerID";
        }
        private void DoanhThu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            
            LoadCombo();
            LoadComboVong();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * from  SoccerMatch where NameRoundID='" + comboBox2.SelectedValue + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SoccerName";
            comboBox1.ValueMember = "SoccerID";
        }
        bool isThoat = true;
        private void button8_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            DvQuanLy a = new DvQuanLy();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thoát !!",
    "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }

        private void DoanhThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void btnvebanra_Click(object sender, EventArgs e)
        {
                string sql = "select SoccerName,SUM(Quantity)[Số vé đã bán ra],TotalTicket from Tickets a  join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID= '" + comboBox1.SelectedValue + "' group by SoccerName,TotalTicket";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                    dataGridView1.DataSource = dt;  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select SoccerName,((SUM(Quantity))*Price)[Doanh thu] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID='" + comboBox1.SelectedValue + "' group by SoccerName, Price ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select b.SoccerName, TotalTicket-(select SUM(Quantity)from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID='" + comboBox1.SelectedValue + "' group by SoccerName, Price )[Số lượng vé tồn kho] from Tickets a full join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID='" + comboBox1.SelectedValue + "' group by SoccerName,TotalTicket ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select b.SoccerName, ((TotalTicket-(select SUM(Quantity)from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID='" + comboBox1.SelectedValue + "' group by SoccerName, Price))*Price )[Doanh thu tổn thất] from Tickets a full join SoccerMatch b on a.SoccerID=b.SoccerID where a.SoccerID='" + comboBox1.SelectedValue + "' group by SoccerName,TotalTicket,Price ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "Select Sum(D)[Tổng doanh thu] from (select (SUM(Quantity)*Price)[D] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID group by SoccerName, Price) as t";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "Select Sum(D)[Tổng doanh thu tổn thất] from (select ((TotalTicket - Quantity)*Price)[D] from Tickets a join SoccerMatch b on a.SoccerID=b.SoccerID ) as t";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
