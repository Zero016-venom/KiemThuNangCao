using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PracticeCRUD_2
{
	public class XeOto
	{
		public XeOto(int ma, string ten, decimal gia, string ghiChu)
		{
			Ma = ma;
			Ten = ten;
			Gia = gia;
			GhiChu = ghiChu;
		}

		public int Ma { get; set; }
		public string Ten { get; set; }
		public decimal Gia { get; set; }
		public string GhiChu { get; set; }

	}
}
