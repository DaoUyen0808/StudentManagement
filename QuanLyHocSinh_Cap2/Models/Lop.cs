using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public string MaKhoi { get; set; }
        public Khoi Khoi { get; set; }
        public List<HocSinh> HocSinhs { get; set; } = new List<HocSinh>();
    }
}
