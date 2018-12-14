using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem
{
    public class User
    {
        public string ID { get; set; }
        public string PassWord { get; set; }
        public string displayName { get; set; }
        public int typeAcc { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte[] Image { get; set; }
    }
}
