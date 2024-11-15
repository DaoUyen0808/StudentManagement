using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class Diem
    {
        public int MaDiem { get; set; }
        public int MaMH { get; set; }
        public int MaHK { get; set; }
        public int MaHS { get; set; }
        public float DiemTB { get; set; }

        public MonHoc MonHoc { get; set; }
        public HocKy HocKy { get; set; }
        public HocSinh HocSinh { get; set; }
        public List<ChiTietDiem> ChiTietDiems { get; set; } = new List<ChiTietDiem>();
    }

}
