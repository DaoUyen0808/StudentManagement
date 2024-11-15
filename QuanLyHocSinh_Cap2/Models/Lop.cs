using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class Lop
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public int MaKhoi { get; set; }

        public Khoi Khoi { get; set; }
        public List<HocSinh> HocSinhs { get; set; } = new List<HocSinh>();
    }
}
