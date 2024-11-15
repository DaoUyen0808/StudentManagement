using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class LoaiKiemTra
    {
        public int MaLoaiKT { get; set; }
        public string TenLoaiKT { get; set; }

        public List<ChiTietDiem> ChiTietDiems { get; set; } = new List<ChiTietDiem>();
    }
}
