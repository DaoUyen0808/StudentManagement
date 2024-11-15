using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class Diem
    {
        public string MaDiem { get; set; }
        public string MaMH { get; set; }
        public string MaHK { get; set; }
        public string MaHS { get; set; }
        public int NamHoc { get; set; }
        public double DiemTB { get; set; }
        public HocSinh HocSinh { get; set; }
        public MonHoc MonHoc { get; set; }
        public HocKy HocKy { get; set; }
        public List<ChiTietDiem> ChiTietDiems { get; set; } = new List<ChiTietDiem>();
    }
}
