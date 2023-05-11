using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ticket_Reservation_Football
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        public bool checkAccount(string ac)
        {

            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,12}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1.Text;
            string mk = textBox2.Text;
            string xacnhanmk = textBox3.Text;
            string email = textBox4.Text;
            if (!checkAccount(tentk))
            {
                MessageBox.Show("Tài khoản dài 6-12 ký tự, có kí tự số, chữ hoa và thường!");
                return;
            }
            if (!checkAccount(mk))
            {
                MessageBox.Show("Mật khẩu dài 6-12 ký tự, có kí tự số, chữ hoa và thường!");
                return;
            }
            if(xacnhanmk != mk)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng xác nhận đúng định dạng gmail");
                return;
            }
            if (modify.TaiKhoans("Select * from Login where Email= '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email đã tồn tại");
                return;
            }
            try
            {
                string query = "Insert Login values('" + tentk + "','" + mk + "','" + email + "')";
                modify.Command(query);
                MessageBox.Show("Đăng kí thành công");
            }
            catch
            {
                MessageBox.Show("Tài khoản này đã được đăng kí");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap a = new DangNhap();
            a.Show();
            DangKy b = new DangKy();
            this.Hide();
        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
