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
    class PhongBanBLL
    {
        //Khởi tạo DataAccess
        PhongBanDAL dalPB;
        public PhongBanBLL()
        {
            dalPB = new PhongBanDAL();
        }
        public DataTable getAllPhongBan()
        {
            return dalPB.getAllPhongBan();
        }
        public bool InsertPhongBan(PhongBan pb)
        {
            return dalPB.InsertPhongBan(pb);
        }
        public bool UpdatePhongBan(PhongBan pb)
        {
            return dalPB.UpdatePhongBan(pb);
        }
        public bool DeletePhongBan(PhongBan pb)
        {
            return dalPB.DeletePhongBan(pb);
        }
    }
}
