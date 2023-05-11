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
    public partial class LayLaiMK : Form
    {
        public LayLaiMK()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if(email.Trim()=="")
            {
                MessageBox.Show("Mời bạn nhập email ");
            }
            else
            {
                string query = "Select * from Login where Email='"+textBox1.Text+"'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    label4.ForeColor = Color.Blue;
                    label4.Text = "Mật khẩu:" + modify.TaiKhoans(query)[0].Matkhau;
                    
                }
                else 
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Email này chưa được đăng kí";
                }
            }
        }

        private void LayLaiMK_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap a = new DangNhap();
            a.Show();
            DangKy b = new DangKy();
            this.Hide();
        }
    }
}
