using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class DangNhap : Form
    {
        List<TaiKhoan> listTaiKhoan = Danhsachtaikhoan.Instance.ListTaiKhoan;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (ktra(txttk.Text, txtmk.Text))
            {
                DvQuanLy f = new DvQuanLy();
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Thông tin tài khoản và mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK);
                txttk.Focus();
            }
        }
         bool ktra(string tentaikhoan, string matkhau)
        {
          for(int i=0; i< listTaiKhoan.Count; i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].MatKhau)
                    return true;
            }
            return false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmk.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                
            }
            else
            {
                txtmk.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                
            }
        }

       
    }
}
