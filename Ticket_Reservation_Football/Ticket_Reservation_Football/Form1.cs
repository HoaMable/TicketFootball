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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xemKếtQuảTrậnĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new KetQuaTranDau();
            frm.MdiParent = this;
            frm.Show();
        }
        private void xemCácTrậnĐấuSắpDiễnRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Lichdau();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thanhToánTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new InVe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thanhToánToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new ThanhToan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đặtVédxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Datve();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngKíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DangKiKhachHang();
            frm.MdiParent = this;
            frm.Show();
            MessageBox.Show("Vui lòng nhập thông tin tài khoản đăng nhập");
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
