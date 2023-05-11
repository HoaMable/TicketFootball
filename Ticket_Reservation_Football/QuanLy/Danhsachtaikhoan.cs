using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
    class Danhsachtaikhoan
    {
        private static Danhsachtaikhoan instance;
        public static Danhsachtaikhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new Danhsachtaikhoan();
                return instance;
            }
            set => instance = value;
        }

        List<TaiKhoan> listTaiKhoan;

        internal List<TaiKhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }


        Danhsachtaikhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("Admin", "1234"));
            listTaiKhoan.Add(new TaiKhoan("Rapphim", "12345"));
        }
    }
}

