using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Data;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.ActorDAL
{
    class NhanVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NhanVienDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNhanVien()
        {
            //Tạo câu lệnh lấy toàn bộ nhân viên
            string sql = "SELECT * FROM NhanVien";
            //Tạo kết nối đến sql
            SqlConnection con = dc.getConnect();
            //Khởi tạo đối tượng của lớp DataAdapter
            da = new SqlDataAdapter(sql, con);
            con.Open();
            //Do du lieu tu SqldataAdapter vao Database
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertNhanVien(NhanVien nv)
        {
            string sql = "INSERT INTO NhanVien(MaNV,HoTenNV,DanToc,GT,NgaySinh,DiaChi,SoCMT,SDT,Email) VALUES(@MaNV,@HoTenNV,@DanToc,@GT,@NgaySinh,@DiaChi,@SoCMT,@SDT,@Email)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nv.MaNV;
                cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar).Value = nv.HoTenNV;
                cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = nv.DanToc;
                cmd.Parameters.Add("@GT", SqlDbType.NVarChar).Value = nv.GT;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add("@SoCMT", SqlDbType.Int).Value = nv.SoCMT;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = nv.SDT;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nv.Email;
                //Thuc thi cau lenh lop Command
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }
        public bool UpdateNhanVien(NhanVien nv)
        {
            string sql = "UPDATE NhanVien SET HoTenNV=@HoTenNV,DanToc=@DanToc,GT=@GT,NgaySinh=@NgaySinh,DiaChi=@DiaChi,SoCMT=@SoCMT,SDT=@SDT,Email=@Email WHERE MaNV=@MaNV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nv.MaNV;
                cmd.Parameters.Add("@HoTenNV", SqlDbType.NVarChar).Value = nv.HoTenNV;
                cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = nv.DanToc;
                cmd.Parameters.Add("@GT", SqlDbType.NVarChar).Value = nv.GT;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add("@SoCMT", SqlDbType.Int).Value = nv.SoCMT;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = nv.SDT;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nv.Email;
                //Thuc thi cau lenh lop Command
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }
        public bool DeleteNhanVien(NhanVien nv)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV=@MaNV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nv.MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
