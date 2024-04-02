using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SinhVien
{
	public class SinhVien
	{
		public SinhVien(int iD, string maSV, string ten)
		{
			ID = iD;
			MaSV = maSV;
			Ten = ten;
		}

		public int ID { get; set; }
		public string MaSV { get; set; }
		public string Ten { get; set; }

	}
}
