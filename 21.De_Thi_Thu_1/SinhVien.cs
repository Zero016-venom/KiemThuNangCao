using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.De_Thi_Thu_1
{
    public class SinhVien
    {
        public SinhVien(string id, string ten, int lop, string email)
        {
            Id = id;
            Ten = ten;
            Lop = lop;
            Email = email;
        }

        public string Id { get; set; }
        public string Ten { get; set; }
        public int Lop { get; set; }
        public string Email { get; set; }

    }
}
