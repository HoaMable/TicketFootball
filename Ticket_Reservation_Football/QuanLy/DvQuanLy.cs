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
    public partial class DvQuanLy : Form
    {
        public DvQuanLy()
        {
            InitializeComponent();
        }

        private void DvQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnchinhsua_Click(object sender, EventArgs e)
        {
            DanhMucChinhSua a = new DanhMucChinhSua();
            a.Show();
            this.Hide();
        }

        private void Btnquanlyve_Click(object sender, EventArgs e)
        {
            DoanhThu a = new DoanhThu();
            string activationCode = "ABC123"; // Mã kích hoạt được xác định trước

            // Hiển thị hộp thoại nhập liệu yêu cầu nhập mã kích hoạt
            string inputCode = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã kích hoạt:", "Yêu cầu nhập mã");

            // So sánh giá trị nhập vào với mã kích hoạt đã xác định
            if (inputCode == activationCode)
            {
                MessageBox.Show("Mã kích hoạt đúng. Chào mừng bạn đến với ứng dụng.");
                // Thực hiện các tác vụ của ứng dụng sau khi mã kích hoạt đúng
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã kích hoạt không đúng. Vui lòng nhập lại.");
                // Xử lý việc nhập lại mã kích hoạt hoặc thoát khỏi ứng dụng
            }
            
            
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
