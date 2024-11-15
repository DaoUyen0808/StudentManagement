using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class Khoi
    {
        public string MaKhoi { get; set; }
        public string TenKhoi { get; set; }
        public int SoLuongLop { get; set; }
        public List<Lop> Lops { get; set; } = new List<Lop>();
    }
}
