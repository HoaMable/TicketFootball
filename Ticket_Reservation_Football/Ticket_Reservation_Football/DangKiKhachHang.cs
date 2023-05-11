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
    public partial class DangKiKhachHang : Form
    {
        string strConnectionString = @"Data Source=HOAPRO\SQLEXPRESS;Initial Catalog=UEFA_Ticket;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;
        public DangKiKhachHang()
        {
            InitializeComponent();
        }
        public void Load_KH()
        {
            da = new SqlDataAdapter("Select CustomerID,Names, TelephoneCustomer,Address,Email,Gender,BirthDate,PaymentID,b.TenTaiKhoan from Customer a join Login b on a.TenTaiKhoan=b.TenTaiKhoan where b.TenTaiKhoan='"+textBox1+"'", conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void LoadCombo()
        {
            da = new SqlDataAdapter("Select * from Payment", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbophuongthuctt.DataSource = dt;
            cbophuongthuctt.DisplayMember = "PayMethod";
            cbophuongthuctt.ValueMember = "PaymentID";
        }
        private void DangKiKhachHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            Load_KH();
            LoadCombo();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtma.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            txtdichi.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();
            txtgioitinh.Text = dataGridView1.Rows[dong].Cells[5].Value.ToString();
            txtngaysinh.Text = dataGridView1.Rows[dong].Cells[6].Value.ToString();
            textBox1.Text = dataGridView1.Rows[dong].Cells[8].Value.ToString();
        }

        private void btndangki_Click(object sender, EventArgs e)
        {

            if (txtma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin mã thành viên");
            }
            else if (txtten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tên thành viên");
            }
            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin số điện thoại");
            }
            else if (txtdichi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin địa chỉ");
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông email");
            }
            else if (txtngaysinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin ngày sinh");
            }
            else if (txtgioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính thành viên");
            }
            else if (cbophuongthuctt.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán");
            }
            else
            {
                try
                {
                    conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    String sql = "Insert Customer values('" + txtma.Text + "','" + txtten.Text + "','"
                        + txtsdt.Text + "','" + txtdichi.Text + "','"
                        + txtngaysinh.Text + "','" + txtgioitinh.Text + "','" + cbophuongthuctt.SelectedValue + "','" + textBox1.Text + "')";
                    DialogResult dlr = MessageBox.Show("Kiểm tra thông tin!! Xác nhận đăng kí ", "Thông báo", MessageBoxButtons.YesNo);
                    if (dlr == DialogResult.Yes)
                        cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
                    Load_KH();

                }
                catch
                {
                    MessageBox.Show("Mã này đã được dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tên tài khoản để đăng kí");
            }
            else
            {
                string sql = "Select CustomerID,Names, TelephoneCustomer,Address,Email,Gender,BirthDate,PaymentID,b.TenTaiKhoan from Customer a full join Login b on a.TenTaiKhoan=b.TenTaiKhoan where b.TenTaiKhoan='" + textBox1.Text + "'";
                da = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            Load_KH();
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
