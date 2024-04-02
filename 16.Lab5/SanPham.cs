using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Lab5
{
	public class SanPham
	{
		public SanPham(string id, string maSanPham, string tenSanPham, double gia, string mauSac, string kichThuoc, int soLuong)
		{
			this.id = id;
			this.maSanPham = maSanPham;
			this.tenSanPham = tenSanPham;
			this.gia = gia;
			this.mauSac = mauSac;
			this.kichThuoc = kichThuoc;
			this.soLuong = soLuong;
		}

		public string id { get; set; }	
		public string maSanPham { get; set; }
		public string tenSanPham { get; set; }
		public double gia { get; set; }
		public string mauSac { get; set; }
		public string kichThuoc { get; set; }
		public int soLuong { get; set; }


	}
}
