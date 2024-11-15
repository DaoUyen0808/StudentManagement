using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class HocKy
    {
        public string MaHK { get; set; }
        public string TenHK { get; set; }
        public List<Diem> Diems { get; set; } = new List<Diem>();
    }
}
