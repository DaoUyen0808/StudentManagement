using StudentManagement.Managers;
using StudentManagement.Views;
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
            UserInterface userInterface = new UserInterface(databaseConfig);

            bool exit = false;
            while (!exit)
            {
                // Gọi hàm để hiển thị menu chính
                ShowMainMenu(databaseConfig, userInterface);
            }
            Console.WriteLine("Thoát khỏi dự án");
            Console.ReadKey();
        }

        static void ShowMainMenu(DatabaseConfig databaseConfig, UserInterface userInterface)
        {
            userInterface.DisplayMainMenu();
            int choice = userInterface.GetUserChoice();
            switch (choice)
            {
                case 1:
                    userInterface.ShowStudentList();
                    break;
                case 2:
                    userInterface.ShowClassList();
                    break;

                case 0:
                    Environment.Exit(0); // Thoát chương trình
                    break;

                default:
                    Console.WriteLine("=> Bạn chọn chưa hợp lệ. Vui lòng chọn lại!");
                    break;
            }
        }
    }
}



