using MySql.Data.MySqlClient;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Managers
{
    class ClassesManager
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly TeacherManager _teacherManager;

        public ClassesManager(DatabaseConfig databaseConfig, TeacherManager teacherManager)
        {
            _databaseConfig = databaseConfig;
            _teacherManager = teacherManager;
        }


        //Lấy toàn bộ các lớp học
        public List<Classes> GetAll()
        {
            string query = "SELECT * FROM CLASSES";
            return _databaseConfig.ExecuteReader(query, reader => new Classes
            {
                ClassID = reader.GetInt32("ClassID"),
                ClassName = reader.GetString("ClassName"),
                TeacherID = reader.GetInt32("TeacherID")
            }
            );
        }

        // Lấy tên lớp từ ClassID
        public string GetClassName(int classId)
        {
            string query = "SELECT ClassName FROM Classes WHERE ClassID = @ClassID";
            var parameters = new Dictionary<string, object>
            {
                { "@ClassID", classId }
            };

            var result = _databaseConfig.ExecuteScalar(query, parameters);
            return result?.ToString() ?? "Unknown";
        }

        //In danh sách các lớp học
        public void Print()
        {
            var classes = GetAll();
            Console.WriteLine("\nDANH SÁCH LỚP HỌC\n");
            // Đặt màu cho tiêu đề
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Mã lớp",-15} {"Lớp",-30} {"Tên giáo viên",-15} ");
            Console.ResetColor();
            foreach (var classe in classes)
            {
                string teacherName = _teacherManager.GetTeacherName(classe.TeacherID);
                Console.WriteLine($"{classe.ClassID,-15} {classe.ClassName,-30} {teacherName,-15} ");
            }

        }
    }
}
