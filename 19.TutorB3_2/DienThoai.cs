using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TutorB3_2
{
	public class DienThoai
	{
		public DienThoai(string id, string ten, float gia, string phanLoai)
		{
			Id = id;
			Ten = ten;
			Gia = gia;
			PhanLoai = phanLoai;
		}

		public string Id { get; set; }
		public string Ten { get; set; }
		public float Gia { get; set; }
		public string PhanLoai { get; set; }
		
	}
}
