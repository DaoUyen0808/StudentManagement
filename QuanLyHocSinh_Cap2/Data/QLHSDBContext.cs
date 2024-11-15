using QuanLyHocSinh_Cap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Data
{
    public class QLHSDBContext
    {
        public List<Khoi> Khois { get; set; } = new List<Khoi>();
        public List<Lop> Lops { get; set; } = new List<Lop>();
        public List<HocSinh> HocSinhs { get; set; } = new List<HocSinh>();
        public List<HocKy> HocKys { get; set; } = new List<HocKy>();
        public List<MonHoc> MonHocs { get; set; } = new List<MonHoc>();
        public List<LoaiKiemTra> LoaiKiemTras { get; set; } = new List<LoaiKiemTra>();
        public List<Diem> Diems { get; set; } = new List<Diem>();
        public List<ChiTietDiem> ChiTietDiems { get; set; } = new List<ChiTietDiem>();

        public QLHSDBContext()
        {
            SeederData();
        }
        public void SeederData()
        {
            // Thêm dữ liệu mẫu vào các danh sách
            // Khối
            Khoi khoi1 = new Khoi { MaKhoi = "K01", TenKhoi = "Khối 10", SoLuongLop = 2 };
            Khoi khoi2 = new Khoi { MaKhoi = "K02", TenKhoi = "Khối 11", SoLuongLop = 2 };
            Khoi khoi3 = new Khoi { MaKhoi = "K03", TenKhoi = "Khối 12", SoLuongLop = 1 };
            Khoi khoi4 = new Khoi { MaKhoi = "K04", TenKhoi = "Khối 9", SoLuongLop = 3 };
            Khoi khoi5 = new Khoi { MaKhoi = "K05", TenKhoi = "Khối 8", SoLuongLop = 4 };
            Khois.AddRange(new List<Khoi> { khoi1, khoi2, khoi3, khoi4, khoi5 });

            // Lớp
            Lop lop1 = new Lop { MaLop = "L01", TenLop = "10A1", SiSo = 30, Khoi = khoi1 };
            Lop lop2 = new Lop { MaLop = "L02", TenLop = "10A2", SiSo = 28, Khoi = khoi1 };
            Lop lop3 = new Lop { MaLop = "L03", TenLop = "11A1", SiSo = 32, Khoi = khoi2 };
            Lop lop4 = new Lop { MaLop = "L04", TenLop = "12A1", SiSo = 29, Khoi = khoi3 };
            Lop lop5 = new Lop { MaLop = "L05", TenLop = "9A1", SiSo = 27, Khoi = khoi4 };
            Lops.AddRange(new List<Lop> { lop1, lop2, lop3, lop4, lop5 });

            // Học sinh
            HocSinh hs1 = new HocSinh { MaHS = "HS01", HoTen = "Nguyễn Văn A", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 5, 20), DiaChi = "Hà Nội", Lop = lop1 };
            HocSinh hs2 = new HocSinh { MaHS = "HS02", HoTen = "Trần Thị B", GioiTinh = "Nữ", NgaySinh = new DateTime(2006, 3, 15), DiaChi = "Hải Phòng", Lop = lop1 };
            HocSinh hs3 = new HocSinh { MaHS = "HS03", HoTen = "Lê Văn C", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 7, 10), DiaChi = "Đà Nẵng", Lop = lop2 };
            HocSinh hs4 = new HocSinh { MaHS = "HS04", HoTen = "Phạm Thị D", GioiTinh = "Nữ", NgaySinh = new DateTime(2004, 8, 18), DiaChi = "Hồ Chí Minh", Lop = lop3 };
            HocSinh hs5 = new HocSinh { MaHS = "HS05", HoTen = "Vũ Văn E", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 9, 25), DiaChi = "Nghệ An", Lop = lop4 };
            HocSinhs.AddRange(new List<HocSinh> { hs1, hs2, hs3, hs4, hs5 });

            // Môn học
            MonHoc mon1 = new MonHoc { MaMon = "M01", TenMon = "Toán" };
            MonHoc mon2 = new MonHoc { MaMon = "M02", TenMon = "Vật Lý" };
            MonHoc mon3 = new MonHoc { MaMon = "M03", TenMon = "Hóa Học" };
            MonHoc mon4 = new MonHoc { MaMon = "M04", TenMon = "Sinh Học" };
            MonHoc mon5 = new MonHoc { MaMon = "M05", TenMon = "Ngữ Văn" };
            MonHocs.AddRange(new List<MonHoc> { mon1, mon2, mon3, mon4, mon5 });

            // Học kỳ
            HocKy hk1 = new HocKy { MaHK = "HK1", TenHK = "Học kỳ 1" };
            HocKy hk2 = new HocKy { MaHK = "HK2", TenHK = "Học kỳ 2" };
            HocKy hk3 = new HocKy { MaHK = "HK3", TenHK = "Học kỳ hè" };
            HocKy hk4 = new HocKy { MaHK = "HK4", TenHK = "Học kỳ bổ túc" };
            HocKy hk5 = new HocKy { MaHK = "HK5", TenHK = "Học kỳ phụ đạo" };
            HocKys.AddRange(new List<HocKy> { hk1, hk2, hk3, hk4, hk5 });

            // Loại kiểm tra
            LoaiKiemTra loaiKT1 = new LoaiKiemTra { MaLoaiKT = "KT1", TenLoaiKT = "Kiểm tra miệng" };
            LoaiKiemTra loaiKT2 = new LoaiKiemTra { MaLoaiKT = "KT2", TenLoaiKT = "Kiểm tra 15 phút" };
            LoaiKiemTra loaiKT3 = new LoaiKiemTra { MaLoaiKT = "KT3", TenLoaiKT = "Kiểm tra 1 tiết" };
            LoaiKiemTra loaiKT4 = new LoaiKiemTra { MaLoaiKT = "KT4", TenLoaiKT = "Kiểm tra giữa kỳ" };
            LoaiKiemTra loaiKT5 = new LoaiKiemTra { MaLoaiKT = "KT5", TenLoaiKT = "Kiểm tra cuối kỳ" };
            LoaiKiemTras.AddRange(new List<LoaiKiemTra> { loaiKT1, loaiKT2, loaiKT3, loaiKT4, loaiKT5 });

            // Điểm
            Diem diem1 = new Diem { MaDiem = "D01", HocSinh = hs1, MonHoc = mon1, HocKy = hk1, NamHoc = 2023, DiemTB = 8.5 };
            Diem diem2 = new Diem { MaDiem = "D02", HocSinh = hs2, MonHoc = mon2, HocKy = hk2, NamHoc = 2023, DiemTB = 7.2 };
            Diem diem3 = new Diem { MaDiem = "D03", HocSinh = hs3, MonHoc = mon3, HocKy = hk3, NamHoc = 2023, DiemTB = 6.5 };
            Diem diem4 = new Diem { MaDiem = "D04", HocSinh = hs4, MonHoc = mon4, HocKy = hk4, NamHoc = 2023, DiemTB = 9.1 };
            Diem diem5 = new Diem { MaDiem = "D05", HocSinh = hs5, MonHoc = mon5, HocKy = hk5, NamHoc = 2023, DiemTB = 8.0 };
            Diems.AddRange(new List<Diem> { diem1, diem2, diem3, diem4, diem5 });

            // Chi tiết điểm
            ChiTietDiem ctd1 = new ChiTietDiem { MaMon = "M01", MaLoaiKT = "KT1", MaDiem = "D01", DiemSo = 8.5, Diem = diem1, MonHoc = mon1, LoaiKiemTra = loaiKT1 };
            ChiTietDiem ctd2 = new ChiTietDiem { MaMon = "M02", MaLoaiKT = "KT2", MaDiem = "D02", DiemSo = 7.0, Diem = diem2, MonHoc = mon2, LoaiKiemTra = loaiKT2 };
            ChiTietDiem ctd3 = new ChiTietDiem { MaMon = "M03", MaLoaiKT = "KT3", MaDiem = "D03", DiemSo = 6.8, Diem = diem3, MonHoc = mon3, LoaiKiemTra = loaiKT3 };
            ChiTietDiem ctd4 = new ChiTietDiem { MaMon = "M04", MaLoaiKT = "KT4", MaDiem = "D04", DiemSo = 9.2, Diem = diem4, MonHoc = mon4, LoaiKiemTra = loaiKT4 };
            ChiTietDiem ctd5 = new ChiTietDiem { MaMon = "M05", MaLoaiKT = "KT5", MaDiem = "D05", DiemSo = 8.3, Diem = diem5, MonHoc = mon5, LoaiKiemTra = loaiKT5 };
            ChiTietDiems.AddRange(new List<ChiTietDiem> { ctd1, ctd2, ctd3, ctd4, ctd5 });
        }
    }
}
