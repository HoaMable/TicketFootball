using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
namespace QuanLy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dto L = new Dto();
        Bus B = new Bus();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = B.ShowDrink();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtma.ResetText();
            txtten.ResetText();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtma.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            txtten.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Mã vòng đấu không được bỏ trống");
            }
            else if (txtten.Text == "")
            {
                MessageBox.Show("Tên vòng đấu không được bỏ trống");
            }
            else
            {
                try
                {
                    L.NameRoundID = Int32.Parse(txtma.Text);
                    L.NameRound = txtten.Text;
                    B.InsertDrink(L.NameRoundID, L.NameRound);
                    MessageBox.Show("Thêm thành công");
                    Form1_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Không nhập trùng mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Mã vòng đấu không được bỏ trống");
            }
            else if (txtten.Text == "")
            {
                MessageBox.Show("Tên vòng không được bỏ trống");
            }
           
            else
            {
                try
                {
                    L.NameRoundID = Int32.Parse(txtma.Text);
                    L.NameRound = txtten.Text;
                   
                    B.UpdateDrink(L.NameRoundID, L.NameRound);
                    MessageBox.Show("Sửa thành công");
                    Form1_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Sai dữ liệu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtma.Text == "")
                {
                    MessageBox.Show("Bạn cần chọn mã vòng đấu để xoá");
                }
                else
                {
                    L.NameRoundID = Int32.Parse(txtma.Text);
                    B.DeleteDrink(L.NameRoundID);
                    MessageBox.Show("Xoá thành công");
                    Form1_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Thư mục không được phép xoá");
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập từ khoá tìm kiếm");
                }
                else
                {
                    dataGridView1.DataSource = B.LookDrink(Int32.Parse(textBox3.Text));
                }

        }
        bool isThoat = true;
        private void btntrove_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            DanhMucChinhSua a = new DanhMucChinhSua();
            a.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thoát !!",
"Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat==true)
            Application.Exit();
        }
    }
}
