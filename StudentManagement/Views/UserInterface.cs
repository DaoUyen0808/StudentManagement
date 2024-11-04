using StudentManagement.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Views
{
    class UserInterface
    {
        private TeacherManager _teacherManager;
        private ClassesManager _classesManager;
        private StudentManager _studentManager;
        public UserInterface(DatabaseConfig databaseConfig)
        {
            // Khởi tạo các đối tượng Manager một lần
            _teacherManager = new TeacherManager(databaseConfig);
            _classesManager = new ClassesManager(databaseConfig, _teacherManager);
            _studentManager = new StudentManager(databaseConfig, _classesManager);
        }

        public void DisplayMainMenu()
        {
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("\n===== DỰ ÁN : QUẢN LÝ HỌC SINH =====");
            Console.WriteLine("1. Hiển thị toàn bộ học sinh");
            Console.WriteLine("2. Hiển thị các lớp học");
            Console.WriteLine("0. Thoát khỏi dự án");
            Console.Write("Chọn chức năng: ");
        }
        public int GetUserChoice()
        {
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("=> Đầu vào không hợp lệ. Vui lòng nhập số.\n");
                return -1; // Giá trị không hợp lệ
            }
        }
        public void WaitForUser()
        {
            Console.Write("\nNhấn phím bất kỳ để quay lại dự án : ");
            Console.ReadKey();
        }
        public void ShowStudentList()
        {
            Console.Clear();
            _studentManager.Print(); 
            WaitForUser();
        }

        public void ShowClassList()
        {
            Console.Clear(); // Xóa màn hình
            _classesManager.Print();
            WaitForUser();

        }
    }
}
