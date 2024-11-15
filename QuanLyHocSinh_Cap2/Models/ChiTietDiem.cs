using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{

    public class ChiTietDiem
    {
        public string MaMon { get; set; }
        public string MaLoaiKT { get; set; }
        public string MaDiem { get; set; }
        public double DiemSo { get; set; }
        public Diem Diem { get; set; }
        public MonHoc MonHoc { get; set; }
        public LoaiKiemTra LoaiKiemTra { get; set; }
    }

}
