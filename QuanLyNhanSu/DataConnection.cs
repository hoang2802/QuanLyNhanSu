using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source=LAPTOP-U4746TND\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";

        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }

    }
}
