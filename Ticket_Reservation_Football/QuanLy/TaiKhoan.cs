using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
    class TaiKhoan
    {
        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;
        }

        private string matKhau;
        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }
        public TaiKhoan(string tentaikhoan, string matkhau)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
        }
    }
}
