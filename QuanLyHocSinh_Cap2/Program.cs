using QuanLyHocSinh_Cap2.Data;
using QuanLyHocSinh_Cap2.LinQ;
using QuanLyHocSinh_Cap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
           // TruyVanDiem_MonHoc truyVanDiem_MonHoc = new TruyVanDiem_MonHoc();
            //truyVanDiem_MonHoc.ShowAverageScores();
            
            while (true)
            {
                // Hiển thị menu
                Console.Clear();
                Console.WriteLine("================== QUẢN LÝ HỌC SINH CẤP 2 ==================");
                Console.WriteLine("1. Quản lý khối");
                Console.WriteLine("2. Quản lý lớp học");
                Console.WriteLine("3. Quản lý học Sinh");
                Console.WriteLine("4. Quản lý môn Học");
                Console.WriteLine("5. Quản lý học Kỳ");
                Console.WriteLine("6. Quản lý kiểm Tra");
                Console.WriteLine("7. Quản lý điểm");
                Console.WriteLine("8. Quản lý chi Tiết Điểm");
                Console.WriteLine("9. Thoát");
                Console.Write("Chọn quản lý bạn muốn xem: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowKhoiMenu();
                        break;
                    case "2":
                        // ShowLop(dbContext.Lops);
                        break;
                    case "3":
                        //  ShowHocSinh(dbContext.HocSinhs);
                        break;
                    case "4":
                        //  ShowMonHoc(dbContext.MonHocs);
                        break;
                    case "5":
                        // ShowHocKy(dbContext.HocKys);
                        break;
                    case "6":
                        //  ShowLoaiKiemTra(dbContext.LoaiKiemTras);
                        break;
                    case "7":
                        //  ShowDiem(dbContext.Diems);
                        break;
                    case "8":
                        // ShowChiTietDiem(dbContext.ChiTietDiems);
                        break;
                    case "9":
                        return; // Thoát chương trình
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }

        // Menu con của Khối
        static void ShowKhoiMenu()
        {
            //TruyVanHocSinh truyVanHocSinh = new TruyVanHocSinh();
            QLHSDBContext dbContext = new QLHSDBContext(); // Khởi tạo dbContext
            TruyVanDiem_MonHoc truyVanDiem_MonHoc = new TruyVanDiem_MonHoc();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("======= Quản Lý Khối =======");
                Console.WriteLine("1. Danh sách thông tin khối");
                Console.WriteLine("2. Hiển thị điểm trung bình");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. Quay lại menu chính");
                Console.Write("Chọn một tùy chọn (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Đang hiển thị điểm trung bình...");
                        truyVanDiem_MonHoc.ShowAverageScores();
                        Console.WriteLine("\nNhấn phím bất kỳ để quay lại...");
                        Console.ReadKey(); // Đợi người dùng nhấn phím
                        break;
                    case "2":

                        Console.Clear();
                        truyVanDiem_MonHoc.ShowTopStudentsByClass();
                        Console.WriteLine("\nNhấn phím bất kỳ để quay lại...");
                        Console.ReadKey(); // Đợi người dùng nhấn phím
                        break;
                    case "3":
                        truyVanDiem_MonHoc.Subject();
                        Console.WriteLine("\nNhấn phím bất kỳ để quay lại...");
                        Console.ReadKey(); // Đợi người dùng nhấn phím
                        break;
                    case "4":
                        truyVanDiem_MonHoc.DanhSachHSDiemTB();
                        Console.WriteLine("\nNhấn phím bất kỳ để quay lại...");
                        Console.ReadKey(); // Đợi người dùng nhấn phím
                        break;
                    case "5":
                        return; // Quay lại menu chính
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }

    }
}