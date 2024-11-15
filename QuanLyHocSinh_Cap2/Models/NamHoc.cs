using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh_Cap2.Models
{
    public class NamHoc
    {
        public int MaNH { get; set; }
        public string namHoc { get; set; }

        public List<Khoi> Khois { get; set; } = new List<Khoi>();
    }
}
