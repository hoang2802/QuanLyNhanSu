using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.ActorDAL;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.ActorBLL
{
    class NhanVienBLL
    {
        //Khởi tạo DataAccess
        NhanVienDAL dalNV;
        public NhanVienBLL()
        {
            dalNV = new NhanVienDAL();
        }
        public DataTable getAllNhanVien()
        {
            return dalNV.getAllNhanVien();
        }
        public bool InsertNhanVien(NhanVien nv)
        {
            return dalNV.InsertNhanVien(nv);
        }
        public bool UpdateNhanVien(NhanVien nv)
        {
            return dalNV.UpdateNhanVien(nv);
        }
        public bool DeleteNhanVien(NhanVien Nv)
        {
            return dalNV.DeleteNhanVien(Nv);
        }
    }
}
