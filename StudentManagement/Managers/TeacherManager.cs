using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Managers
{
    class TeacherManager
    {
        private readonly DatabaseConfig _databaseConfig;

        public TeacherManager(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }


        //Lấy toàn bộ các giáo viên
        public List<Teachers> GetAll()
        {
            string query = "SELECT * FROM Teachers WHERE IsDeleted=FALSE";
            return _databaseConfig.ExecuteReader(query, reader => new Teachers
            {
                TeacherID = reader.GetInt32("TeacherID"),
                FullName = reader.GetString("FullName"),
                PhoneNumber = reader.GetString("PhoneNumber"),
                SubjectID = reader.GetInt32("SubjectID")
            }
            );
        }

        // Lấy tên giáo viên từ  TeacherID
        public string GetTeacherName(int teacherId)
        {
            string query = "SELECT FullName FROM Teachers WHERE TeacherID = @TeacherID";
            var parameters = new Dictionary<string, object>
            {
                { "@TeacherID", teacherId }
            };

            var result = _databaseConfig.ExecuteScalar(query, parameters);
            return result?.ToString() ?? "Unknown";
        }

        //In danh sách giáo viên
        public void Print()
        {
            var Teachers = GetAll();
            Console.WriteLine("\nDANH SÁCH GIÁO VIÊN\n");
            // Đặt màu cho tiêu đề
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Mã giáo viên",-15} {"Họ tên",-30} {"SĐT",-15} {"Môn học",-15}");
            Console.ResetColor();
            foreach (var teachers in Teachers)
            {
                Console.WriteLine($"{teachers.TeacherID,-15} {teachers.FullName,-30} {teachers.PhoneNumber,-15} {teachers.SubjectID,-15}");
            }

        }
    }
}
