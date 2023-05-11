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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy a = new DangKy();
            a.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LayLaiMK b = new LayLaiMK();
            b.Show();
            this.Hide();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1.Text;
            string mk = textBox2.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản của bạn");
            }else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu của bạn");
            }
            else
            {
                string query = "Select * from Login where TenTaiKhoan= '"+tentk+"' and MatKhau= '"+mk+"' ";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    Form1 a = new Form1();
                    a.Show();
                    DangNhap b = new DangNhap();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
