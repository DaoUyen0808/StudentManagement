using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{

    public class ChiTietDiem
    {
        public int MaMon { get; set; }
        public int MaLoaiKT { get; set; }
        public int MaDiem { get; set; }
        public float DiemSo { get; set; }

        public MonHoc MonHoc { get; set; }
        public LoaiKiemTra LoaiKiemTra { get; set; }
        public Diem Diem { get; set; }
    }


}
