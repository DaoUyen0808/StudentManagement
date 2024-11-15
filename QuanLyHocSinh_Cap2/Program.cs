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
            TruyVanHocSinh truyVanHocSinh = new TruyVanHocSinh();
            QLHSDBContext dbContext = new QLHSDBContext();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("======= Quản Lý Khối =======");
                Console.WriteLine("1. Danh sách thông tin khối");
                Console.WriteLine("2. ");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. Quay lại menu chính");
                Console.Write("Chọn một tùy chọn (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        truyVanHocSinh.ShowKhoi(dbContext.Khois);
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":
                        return; // Quay lại menu chính
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

            }
        }
        /*

        // Các phương thức hiển thị dữ liệu của lớp Khoi
        static void ShowKhoi(List<Khoi> khois)
        {
            Console.Clear();
            Console.WriteLine("======= Danh sách Khối =======");
            foreach (var khoi in khois)
            {
                Console.WriteLine($"Mã Khối: {khoi.MaKhoi}, Tên Khối: {khoi.TenKhoi}, Số Lượng Lớp: {khoi.SoLuongLop}");
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại...");
            Console.ReadKey();
        }

     

        // Hiển thị dữ liệu của lớp Lop
        static void ShowLop(List<Lop> lops)
        {
            Console.Clear();
            Console.WriteLine("==== Dữ Liệu Lớp ====");
            foreach (var lop in lops)
            {
                Console.WriteLine($"Mã Lớp: {lop.MaLop}, Tên Lớp: {lop.TenLop}, Sĩ Số: {lop.SiSo}, Khối: {lop.Khoi.TenKhoi}");
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }

        // Hiển thị dữ liệu của lớp HocSinh
        static void ShowHocSinh(List<HocSinh> hocSinhs)
        {
            Console.Clear();
            Console.WriteLine("==== Dữ Liệu Học Sinh ====");
            foreach (var hs in hocSinhs)
            {
                Console.WriteLine($"Mã Học Sinh: {hs.MaHS}, Họ Tên: {hs.HoTen}, Giới Tính: {hs.GioiTinh}, Ngày Sinh: {hs.NgaySinh.ToShortDateString()}, Địa Chỉ: {hs.DiaChi}, Lớp: {hs.Lop.TenLop}");
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }

        // Hiển thị dữ liệu của lớp MonHoc
        static void ShowMonHoc(List<MonHoc> monHocs)
        {
            Console.Clear();
            Console.WriteLine("==== Dữ Liệu Môn Học ====");
            foreach (var mon in monHocs)
            {
                Console.WriteLine($"Mã Môn: {mon.MaMon}, Tên Môn: {mon.TenMon}");
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }

        // Hiển thị dữ liệu của lớp HocKy
        static void ShowHocKy(List<HocKy> hocKys)
        {
            Console.Clear();
            Console.WriteLine("==== Dữ Liệu Học Kỳ ====");
            foreach (var hk in hocKys)
            {
                Console.WriteLine($"Mã Học Kỳ: {hk.MaHK}, Tên Học Kỳ: {hk.TenHK}");
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }

        // Hiển thị dữ liệu của lớp LoaiKiemTra
        static void ShowLoaiKiemTra(List<LoaiKiemTra> loaiKiemTras)
        {
            Console.Clear();
            Console.WriteLine("==== Dữ Liệu Loại Kiểm Tra ====");
            foreach (var kt in loaiKiemTras)
            {
                Console.WriteLine($"Mã Loại Kiểm Tra: {kt.MaLoaiKT}, Tên Loại Kiểm Tra: {kt.TenLoaiKT}");
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }

        // Hiển thị dữ liệu của lớp Diem
        static void ShowDiem(List<Diem> diems)
        {
            Console.Clear();
            Console.WriteLine("==== Dữ Liệu Điểm ====");
            foreach (var diem in diems)
            {
                Console.WriteLine($"Mã Điểm: {diem.MaDiem}, Học Sinh: {diem.HocSinh.HoTen}, Môn Học: {diem.MonHoc.TenMon}, Học Kỳ: {diem.HocKy.TenHK}, Điểm TB: {diem.DiemTB}");
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }

        // Hiển thị dữ liệu của lớp ChiTietDiem
        static void ShowChiTietDiem(List<ChiTietDiem> chiTietDiems)
        {
            Console.Clear();
            Console.WriteLine("==== Dữ Liệu Chi Tiết Điểm ====");
            foreach (var ctd in chiTietDiems)
            {
                Console.WriteLine($"Mã Môn: {ctd.MaMon}, Mã Loại Kiểm Tra: {ctd.MaLoaiKT}, Mã Điểm: {ctd.MaDiem}, Điểm: {ctd.DiemSo}");
            }
            Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
            Console.ReadKey();
        }
    }*/
    }
}