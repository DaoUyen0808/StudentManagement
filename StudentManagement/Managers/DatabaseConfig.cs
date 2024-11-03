using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Managers
{
    class DatabaseConfig
    {
        // Chuỗi kết nối tới cơ sở dữ liệu
        private static readonly string connectionString = "server=localhost;user=root;password=123456;database=Student_Management;";

        //Phương thức mở kết nối
        public MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public List<T> ExecuteReader<T>(string query, Func<MySqlDataReader, T> map)
        {
            List<T> results = new List<T>();

            using (var conn = GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    results.Add(map(reader)); // Sử dụng hàm map để chuyển đổi dữ liệu
                }
            }

            return results;
        }
    }

  
}
