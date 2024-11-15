using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class HocSinh
    {
        public int MaHS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int MaLop { get; set; }

        public Lop Lop { get; set; }
        public List<Diem> Diems { get; set; } = new List<Diem>();
    }
}
