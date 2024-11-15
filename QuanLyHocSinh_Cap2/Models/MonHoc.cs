using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class MonHoc
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public List<Diem> Diems { get; set; } = new List<Diem>();
        public List<ChiTietDiem> ChiTietDiems { get; set; } = new List<ChiTietDiem>();
    }
}
