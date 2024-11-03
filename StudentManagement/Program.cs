using StudentManagement.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            DatabaseConfig databaseConfig = new DatabaseConfig();

            bool exit = false;
            while (!exit)
            {
                // Gọi hàm để hiển thị menu chính
                ShowMainMenu(databaseConfig);
            }
            Console.WriteLine("Thoát khỏi dự án");
            Console.ReadKey();
        }

        static void ShowMainMenu(DatabaseConfig databaseConfig)
        {
            Console.Clear(); // Xóa màn hình
            Console.WriteLine("\n===== DỰ ÁN : QUẢN LÝ HỌC SINH =====");
            Console.WriteLine("1. Hiển thị toàn bộ học sinh");
            Console.WriteLine("0. Thoát khỏi dự án");
            Console.Write("Chọn chức năng: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ShowStudentList(databaseConfig);
                        break;

                    case 0:
                        Environment.Exit(0); // Thoát chương trình
                        break;

                    default:
                        Console.WriteLine("=> Bạn chọn chưa hợp lệ. Vui lòng chọn lại!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("=> Đầu vào không hợp lệ. Vui lòng nhập số.\n");
            }
        }

        static void ShowStudentList(DatabaseConfig databaseConfig)
        {
            Console.Clear(); // Xóa màn hình
            StudentManager studentManager = new StudentManager(databaseConfig);
            studentManager.Print();
            Console.Write("\nNhấn phím bất kỳ để quay lại dự án : ");
            Console.ReadKey();
        }
    }
    }


