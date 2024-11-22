using QuanLyHocSinh_Cap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Data
{
    public class QLHSDBContext
    {
        public List<NamHoc> NamHocs { get; set; } = new List<NamHoc>();
        public List<Khoi> Khois { get; set; } = new List<Khoi>();
        public List<Lop> Lops { get; set; } = new List<Lop>();
        public List<HocSinh> HocSinhs { get; set; } = new List<HocSinh>();
        public List<HocKy> HocKys { get; set; } = new List<HocKy>();
        public List<MonHoc> MonHocs { get; set; } = new List<MonHoc>();
        public List<Diem> Diems { get; set; } = new List<Diem>();
        public List<ChiTietDiem> ChiTietDiems { get; set; } = new List<ChiTietDiem>();
        public List<LoaiKiemTra> LoaiKiemTras { get; set; } = new List<LoaiKiemTra>();

        public QLHSDBContext()
        {
            SeederData();
        }

        public void SeederData()
        {
            // Nam học
            NamHoc nh1 = new NamHoc { MaNH = 1, namHoc = "2022-2023" };
            NamHoc nh2 = new NamHoc { MaNH = 2, namHoc = "2023-2024" };
            NamHoc nh3 = new NamHoc { MaNH = 3, namHoc = "2024-2025" };
            NamHoc nh4 = new NamHoc { MaNH = 4, namHoc = "2025-2026" };
            NamHoc nh5 = new NamHoc { MaNH = 5, namHoc = "2026-2027" };
            NamHocs.AddRange(new List<NamHoc> { nh1, nh2, nh3, nh4, nh5 });

            // Khối
            Khoi khoi1 = new Khoi { MaKhoi = 1, TenKhoi = "Khối 10", SoLuongLop = 2, MaNH = nh1.MaNH, NamHoc = nh1 };
            Khoi khoi2 = new Khoi { MaKhoi = 2, TenKhoi = "Khối 11", SoLuongLop = 2, MaNH = nh2.MaNH, NamHoc = nh2 };
            Khoi khoi3 = new Khoi { MaKhoi = 3, TenKhoi = "Khối 12", SoLuongLop = 1, MaNH = nh3.MaNH, NamHoc = nh3 };
            Khoi khoi4 = new Khoi { MaKhoi = 4, TenKhoi = "Khối 9", SoLuongLop = 3, MaNH = nh4.MaNH, NamHoc = nh4 };
            Khoi khoi5 = new Khoi { MaKhoi = 5, TenKhoi = "Khối 8", SoLuongLop = 4, MaNH = nh5.MaNH, NamHoc = nh5 };
            Khois.AddRange(new List<Khoi> { khoi1, khoi2, khoi3, khoi4, khoi5 });

            // Lớp
            Lop lop1 = new Lop { MaLop = 1, TenLop = "10A1", SiSo = 30, MaKhoi = khoi1.MaKhoi, Khoi = khoi1 };
            Lop lop2 = new Lop { MaLop = 2, TenLop = "10A2", SiSo = 28, MaKhoi = khoi1.MaKhoi, Khoi = khoi1 };
            Lop lop3 = new Lop { MaLop = 3, TenLop = "11A1", SiSo = 32, MaKhoi = khoi2.MaKhoi, Khoi = khoi2 };
            Lop lop4 = new Lop { MaLop = 4, TenLop = "12A1", SiSo = 29, MaKhoi = khoi3.MaKhoi, Khoi = khoi3 };
            Lop lop5 = new Lop { MaLop = 5, TenLop = "9A1", SiSo = 27, MaKhoi = khoi4.MaKhoi, Khoi = khoi4 };
            Lops.AddRange(new List<Lop> { lop1, lop2, lop3, lop4, lop5 });

            // Học sinh
            HocSinh hs1 = new HocSinh { MaHS = 1, HoTen = "Nguyễn Văn A", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 5, 20), DiaChi = "Hà Nội", MaLop = lop1.MaLop, Lop = lop1 };
            HocSinh hs2 = new HocSinh { MaHS = 2, HoTen = "Trần Thị B", GioiTinh = "Nữ", NgaySinh = new DateTime(2006, 3, 15), DiaChi = "Hải Phòng", MaLop = lop1.MaLop, Lop = lop1 };
            HocSinh hs3 = new HocSinh { MaHS = 3, HoTen = "Lê Văn C", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 7, 10), DiaChi = "Đà Nẵng", MaLop = lop2.MaLop, Lop = lop2 };
            HocSinh hs4 = new HocSinh { MaHS = 4, HoTen = "Phạm Thị D", GioiTinh = "Nữ", NgaySinh = new DateTime(2004, 8, 18), DiaChi = "Hồ Chí Minh", MaLop = lop3.MaLop, Lop = lop3 };
            HocSinh hs5 = new HocSinh { MaHS = 5, HoTen = "Vũ Văn E", GioiTinh = "Nam", NgaySinh = new DateTime(2005, 9, 25), DiaChi = "Nghệ An", MaLop = lop4.MaLop, Lop = lop4 };
            HocSinhs.AddRange(new List<HocSinh> { hs1, hs2, hs3, hs4, hs5 });

            // Học kỳ
            HocKy hk1 = new HocKy { MaHK = 1, TenHK = "Học kỳ 1" };
            HocKy hk2 = new HocKy { MaHK = 2, TenHK = "Học kỳ 2" };
            HocKy hk3 = new HocKy { MaHK = 3, TenHK = "Học kỳ hè" };
            HocKy hk4 = new HocKy { MaHK = 4, TenHK = "Học kỳ bổ túc" };
            HocKy hk5 = new HocKy { MaHK = 5, TenHK = "Học kỳ phụ đạo" };
            HocKys.AddRange(new List<HocKy> { hk1, hk2, hk3, hk4, hk5 });

            // Môn học
            MonHoc mon1 = new MonHoc { MaMon = 1, TenMon = "Toán" };
            MonHoc mon2 = new MonHoc { MaMon = 2, TenMon = "Vật Lý" };
            MonHoc mon3 = new MonHoc { MaMon = 3, TenMon = "Hóa Học" };
            MonHoc mon4 = new MonHoc { MaMon = 4, TenMon = "Sinh Học" };
            MonHoc mon5 = new MonHoc { MaMon = 5, TenMon = "Ngữ Văn" };
            MonHocs.AddRange(new List<MonHoc> { mon1, mon2, mon3, mon4, mon5 });

            // Loại kiểm tra
            LoaiKiemTra loaiKT1 = new LoaiKiemTra { MaLoaiKT = 1, TenLoaiKT = "Kiểm tra miệng" };
            LoaiKiemTra loaiKT2 = new LoaiKiemTra { MaLoaiKT = 2, TenLoaiKT = "Kiểm tra 15 phút" };
            LoaiKiemTra loaiKT3 = new LoaiKiemTra { MaLoaiKT = 3, TenLoaiKT = "Kiểm tra 1 tiết" };
            LoaiKiemTra loaiKT4 = new LoaiKiemTra { MaLoaiKT = 4, TenLoaiKT = "Kiểm tra giữa kỳ" };
            LoaiKiemTra loaiKT5 = new LoaiKiemTra { MaLoaiKT = 5, TenLoaiKT = "Kiểm tra cuối kỳ" };
            LoaiKiemTras.AddRange(new List<LoaiKiemTra> { loaiKT1, loaiKT2, loaiKT3, loaiKT4, loaiKT5 });

            // Điểm
            Diem diem1 = new Diem { MaDiem = 1, MaMH = mon1.MaMon, MaHK = hk1.MaHK, MaHS = hs1.MaHS, DiemTB = 8.5f, MonHoc = mon1, HocKy = hk1, HocSinh = hs1 };
            Diem diem2 = new Diem { MaDiem = 2, MaMH = mon2.MaMon, MaHK = hk2.MaHK, MaHS = hs2.MaHS, DiemTB = 7.5f, MonHoc = mon2, HocKy = hk2, HocSinh = hs2 };
            Diem diem3 = new Diem { MaDiem = 3, MaMH = mon3.MaMon, MaHK = hk3.MaHK, MaHS = hs3.MaHS, DiemTB = 6.5f, MonHoc = mon3, HocKy = hk3, HocSinh = hs3 };
            Diem diem4 = new Diem { MaDiem = 4, MaMH = mon4.MaMon, MaHK = hk4.MaHK, MaHS = hs4.MaHS, DiemTB = 9.0f, MonHoc = mon4, HocKy = hk4, HocSinh = hs4 };
            Diem diem5 = new Diem { MaDiem = 5, MaMH = mon5.MaMon, MaHK = hk5.MaHK, MaHS = hs5.MaHS, DiemTB = 8.0f, MonHoc = mon5, HocKy = hk5, HocSinh = hs5 };
            Diems.AddRange(new List<Diem> { diem1, diem2, diem3, diem4, diem5 });

            // Chi tiết điểm
            ChiTietDiem ctd1 = new ChiTietDiem { MaMon = mon1.MaMon, MaLoaiKT = loaiKT1.MaLoaiKT, MaDiem = diem1.MaDiem, DiemSo = 8.5f, MonHoc = mon1, LoaiKiemTra = loaiKT1, Diem = diem1 };
            ChiTietDiem ctd2 = new ChiTietDiem { MaMon = mon2.MaMon, MaLoaiKT = loaiKT2.MaLoaiKT, MaDiem = diem2.MaDiem, DiemSo = 7.0f, MonHoc = mon2, LoaiKiemTra = loaiKT2, Diem = diem2 };
            ChiTietDiem ctd3 = new ChiTietDiem { MaMon = mon3.MaMon, MaLoaiKT = loaiKT3.MaLoaiKT, MaDiem = diem3.MaDiem, DiemSo = 6.0f, MonHoc = mon3, LoaiKiemTra = loaiKT3, Diem = diem3 };
            ChiTietDiem ctd4 = new ChiTietDiem { MaMon = mon4.MaMon, MaLoaiKT = loaiKT4.MaLoaiKT, MaDiem = diem4.MaDiem, DiemSo = 9.5f, MonHoc = mon4, LoaiKiemTra = loaiKT4, Diem = diem4 };
            ChiTietDiem ctd5 = new ChiTietDiem { MaMon = mon5.MaMon, MaLoaiKT = loaiKT5.MaLoaiKT, MaDiem = diem5.MaDiem, DiemSo = 8.0f, MonHoc = mon5, LoaiKiemTra = loaiKT5, Diem = diem5 };
            ChiTietDiems.AddRange(new List<ChiTietDiem> { ctd1, ctd2, ctd3, ctd4, ctd5 });
        }

       

    }
}