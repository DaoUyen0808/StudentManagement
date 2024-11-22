using QuanLyHocSinh_Cap2.Data;
using QuanLyHocSinh_Cap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyHocSinh_Cap2.LinQ
{
    /* ĐỀ CÁC CÂU LINQ GIỮA ĐIỂM VÀ MÔN HỌC:
    * 1.Lấy danh sách học sinh và điểm trung bình của từng học sinh
    * 2.Lấy danh sách học sinh có điểm trung bình cao nhất trong lớp
    * 3.Lấy danh sách các môn học
    * 4.Lấy danh sách học sinh và điểm trung bình của từng môn học
    * 5.Lấy danh sách học sinh có điểm trung bình dưới 5 ở một môn học
    * 6.Lấy danh sách học sinh có điểm trung bình tất cả các môn trên 8
    * 7.Lấy danh sách học sinh có điểm trung bình cao nhất từng khối
    * 8.Lấy danh sách các loại kiểm tra và điểm trung bình của từng loại kiểm tra cho mỗi học sinh
    * 9.Lấy danh sách học sinh có điểm kiểm tra lần đầu tiên cao nhất trong một môn học cụ thể
    */
    public class TruyVanDiem_MonHoc
    {

        private QLHSDBContext dbContext;

        public TruyVanDiem_MonHoc()
        {
            dbContext = new QLHSDBContext(); // Khởi tạo dbContext ở đây
        }

        //Lấy danh sách học sinh và điểm trung bình của từng học sinh
        public void ShowAverageScores()
        {
            var averageScores = from hs in dbContext.HocSinhs
                                join diem in dbContext.Diems on hs.MaHS equals diem.MaHS
                                group diem by hs into g
                                select new
                                {
                                    HoTen = g.Key.HoTen,
                                    DiemTB = g.Average(d => d.DiemTB)
                                };

            Console.WriteLine("Danh sách học sinh và điểm trung bình:");
            foreach (var item in averageScores)
            {
                Console.WriteLine($"Học Sinh: {item.HoTen}, Điểm Trung Bình: {item.DiemTB}");
            }

            if (!averageScores.Any())
            {
                Console.WriteLine("Không có học sinh nào để hiển thị điểm trung bình.");
            }
        }

        //Lấy danh sách học sinh có điểm trung bình cao nhất trong lớp
        public void ShowTopStudentsByClass()
        {
            var topStudentsByClass = from hs in dbContext.HocSinhs
                                     join diem in dbContext.Diems on hs.MaHS equals diem.MaHS
                                     group new { hs, diem.DiemTB } by hs.MaLop into g // Nhóm theo lớp
                                     let maxScore = g.Max(x => x.DiemTB) // Tìm điểm cao nhất trong từng lớp
                                     select new
                                     {
                                         MaLop = g.Key,
                                         TopStudents = g.Where(x => x.DiemTB == maxScore) // Lọc học sinh có điểm cao nhất
                                     };

            Console.WriteLine("Danh sách học sinh có điểm trung bình cao nhất trong từng lớp:");
            foreach (var lop in topStudentsByClass)
            {
                Console.WriteLine($"Lớp: {lop.MaLop}");
                foreach (var student in lop.TopStudents)
                {
                    Console.WriteLine($"- Học Sinh: {student.hs.HoTen}, Điểm Trung Bình: {student.DiemTB}, Mã HS: {student.hs.MaHS}");
                }
            }

            if (!topStudentsByClass.Any())
            {
                Console.WriteLine("Không có học sinh nào để hiển thị.");
            }
        }
        //Lấy danh sách các môn học
        public void Subject()
        {
            var subject = dbContext.MonHocs.Select(mh => new { mh.MaMon, mh.TenMon });
            if (!subject.Any())
            {
                Console.WriteLine("Không có môn học nào.");
                return;
            }
            Console.WriteLine("Danh sách các môn học");
           
                foreach (var subjects in subject)
                {
                    Console.WriteLine($"Mã môn: {subjects.MaMon}, Tên môn: {subjects.TenMon}");
                }
        }
        //Lấy danh sách học sinh và điểm trung bình của từng môn học
        public void DanhSachHSDiemTB()
        {
            var danhSach = from hs in dbContext.HocSinhs
                           join diem in dbContext.Diems on hs.MaHS equals diem.MaHS
                           join mh in dbContext.MonHocs on diem.MaMH equals mh.MaMon
                           group diem by new { hs.MaHS, hs.HoTen,mh.TenMon } into g
                          
                           select new
                           {
                               MaHS = g.Key.MaHS,
                               HoTen= g.Key.HoTen,
                               TenMH= g.Key.TenMon,
                               DiemTB = g.Average(d => d.DiemTB)
                               

                           } ;
            Console.WriteLine("danh sách học sinh và điểm trung bình của từng môn học");

            foreach (var ds in danhSach)
            {
                Console.WriteLine($"Mã học sinh: {ds.MaHS}, Tên học sinh: {ds.HoTen},Tên môn:{ds.TenMH},Điểm TB:{ds.DiemTB}");

            }

        }
        //Lấy danh sách học sinh có điểm trung bình dưới 5 ở một môn học
        public void DanhSachHSDiemTBDuoi5()
        {
            var danhSach = from hs in dbContext.HocSinhs
                           join diem in dbContext.Diems on hs.MaHS equals diem.MaHS
                           join mh in dbContext.MonHocs on diem.MaMH equals mh.MaMon
                           group diem by new { hs.MaHS, hs.HoTen, mh.TenMon } into g

                           select new
                           {
                               MaHS = g.Key.MaHS,
                               HoTen = g.Key.HoTen,
                               TenMH = g.Key.TenMon,
                               DiemTB = g.Average(d => d.DiemTB)


                           } into result
                           where result.DiemTB < 5
                           select result;
            Console.WriteLine("danh sách học sinh và điểm trung bình của từng môn học");

            foreach (var ds in danhSach)
            {
                Console.WriteLine($"Mã học sinh: {ds.MaHS}, Tên học sinh: {ds.HoTen},Tên môn:{ds.TenMH},Điểm TB:{ds.DiemTB}");

            }

        }
    }
}
    

