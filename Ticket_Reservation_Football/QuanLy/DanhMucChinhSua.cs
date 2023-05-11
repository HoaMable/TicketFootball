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
    public partial class DanhMucChinhSua : Form
    {
        bool isThoat = true;
        public DanhMucChinhSua()
        {
            InitializeComponent();
        }

        private void btnvongdau_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void btntrandau_Click(object sender, EventArgs e)
        {
            UpadateTranDau b = new UpadateTranDau();
            b.Show();
            this.Hide();
        }

        private void DanhMucChinhSua_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat==true)
            Application.Exit();
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            DvQuanLy a = new DvQuanLy();
            a.Show();
        }

    }
}
