using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.ActorDAL
{
    class PhongBanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PhongBanDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllPhongBan()
        {
            //Tạo câu lệnh lấy toàn bộ nhân viên
            string sql = "SELECT * FROM PhongBan";
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
        public bool InsertPhongBan(PhongBan pb)
        {
            string sql = "INSERT INTO PhongBan(MaPB,TenPB,DiaChi,SDTPhongBan) VALUES(@MaPB,@TenPB,@DiaChi,@SDTPhongBan)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaPB", SqlDbType.VarChar).Value = pb.MaPB;
                cmd.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = pb.TenPB;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pb.DiaChi;
                cmd.Parameters.Add("@SDTPhongBan", SqlDbType.Int).Value = pb.SDTPhongBan;
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
        public bool UpdatePhongBan(PhongBan pb)
        {
            string sql = "UPDATE PhongBan SET TenPB=@TenPB,DiaChi=@DiaChi,SDTPhongBan=@SDTPhongBan WHERE MaPB=@MaPB";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaPB", SqlDbType.VarChar).Value = pb.MaPB;
                cmd.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = pb.TenPB;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pb.DiaChi;
                cmd.Parameters.Add("@SDTPhongBan", SqlDbType.Int).Value = pb.SDTPhongBan;
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
        public bool DeletePhongBan(PhongBan pb)
        {
            string sql = "DELETE FROM PhongBan WHERE MaPB=@MaPB";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaPB", SqlDbType.VarChar).Value = pb.MaPB;
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
