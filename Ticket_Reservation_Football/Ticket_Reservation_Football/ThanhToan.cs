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
    public partial class ThanhToan : Form
    {
        string strConnectionString = @"Data Source=HOAPRO\SQLEXPRESS;Initial Catalog=UEFA_Ticket;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public ThanhToan()
        {
            InitializeComponent();
        }
        

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtma.Text= dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txttenkh.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            cbptthanhtoan.Text= dataGridView1.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Mời bạn nhập mã khách hàng");
            }
            else
            {
                conn = new SqlConnection(strConnectionString);
                string sql = "Select b.CustomerID,Names,c.SoccerName,Quantity,SUM(Price*Quantity)[Total] from Customer a join Tickets b on a.CustomerID=b.CustomerID join SoccerMatch c on c.SoccerID=b.SoccerID where a.CustomerID='" + txtma.Text + "'group by Names,b.CustomerID,SoccerName,Quantity";
                DialogResult dlr = MessageBox.Show("Bạn muốn thanh toán chứ ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Thanh toán thành công! Hẹn gặp lại quý khách");
            }
        }

        private void btntongtien_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Mời bạn nhập mã khách hàng");
            }
            else
            {
                conn = new SqlConnection(strConnectionString);
                string sql = "Select Sum(Total)[Tổng số tiền],Names from (Select b.CustomerID,Names,c.SoccerName,Quantity,SUM(Price*Quantity)[Total] from Customer a join Tickets b on a.CustomerID=b.CustomerID join SoccerMatch c on c.SoccerID=b.SoccerID where a.CustomerID='" + txtma.Text + "' group by Names,b.CustomerID,SoccerName,Quantity ) as t group by t.Names";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                da = new SqlDataAdapter("Select * from Payment", conn);
                dt = new DataTable();
                da.Fill(dt);
                cbptthanhtoan.DataSource = dt;
                cbptthanhtoan.DisplayMember = "PayMethod";
                cbptthanhtoan.ValueMember = "PaymentID";
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thoát !!",
"Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txttenkh.Text = dataGridView2.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
