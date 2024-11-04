using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Managers
{
    class StudentManager
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly ClassesManager _classesManager;

        public StudentManager(DatabaseConfig databaseConfig, ClassesManager classesManager)
        {
            _databaseConfig = databaseConfig;
            _classesManager = classesManager;
        }




        //Lấy toàn bộ danh sách học sinh
        public List<Students> GetAll()
        {
            string query = "SELECT * FROM STUDENTS WHERE IsDeleted=FALSE";
            return _databaseConfig.ExecuteReader(query, reader => new Students
            {
                StudentID = reader.GetInt32("StudentID"),
                FullName = reader.GetString("FullName"),
                DateOfBirth = reader.GetDateTime("DateOfBirth"),
                Gender = reader.GetBoolean("Gender"),
                Address = reader.GetString("Address"),
                PhoneNumber = reader.GetString("PhoneNumber"),
                Email = reader.GetString("Email"),
                ClassID = reader.GetInt32("ClassID")
            }
            );
        }

        //In danh sách học sinh
        public void Print()
        {
            var students = GetAll();
            Console.WriteLine("\nDANH SÁCH HỌC SINH\n");
            // Đặt màu cho tiêu đề
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Mã học sinh",-15} {"Họ và tên",-30} {"Ngày sinh",-15} {"Giới tính",-10} {"Địa chỉ",-25} {"Số điện thoại",-15} {"Email",-30} {"Lớp",-15}");
            Console.ResetColor();
            foreach (var student in students)
            {
                // Lấy tên lớp dựa trên ClassID
                string className = _classesManager.GetClassName(student.ClassID);
                Console.WriteLine($"{student.StudentID,-15} {student.FullName,-30} {student.DateOfBirth.ToShortDateString(),-15} {(student.Gender ? "Nữ" : "Nam"),-10} {student.Address,-25} {student.PhoneNumber,-15} {student.Email,-30} {className,- 15}");
            }

        }
    }
}
