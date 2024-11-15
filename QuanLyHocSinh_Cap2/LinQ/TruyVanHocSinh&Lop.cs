using QuanLyHocSinh_Cap2.Data;
using QuanLyHocSinh_Cap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.LinQ
{
    /* ĐỀ CÁC CÂU LINQ:
     * 1.Lấy danh sách tất cả học sinh
     * 2.Lấy danh sách học sinh trong một lớp cụ thể
     * 3.Lấy danh sách học sinh trong một khối cụ thể
     * 4.Lấy tên học sinh và lớp của họ
     * 5.Lấy học sinh có độ tuổi lớn nhất
     * 6.Lấy học sinh có độ tuổi nhỏ nhất
     * 7.Lấy danh sách lớp và số lượng học sinh trong từng lớp
     * 8.Đếm số lượng học sinh trong mỗi khối
     * 9.Lấy danh sách học sinh theo giới tính
     * 10.Lấy danh sách học sinh nữ trong một lớp
     */
    public class TruyVanHocSinh
    {
        // Khởi tạo đối tượng QLHSDBContext để có thể truy cập dữ liệu
        private QLHSDBContext dbContext = new QLHSDBContext();

        public void ShowKhoi(List<Khoi> khois)
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

    }
}
