using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TutorB3
{
	public class DanhgiaGrader
	{
		public string XepLoai(int a)
		{
			if (a < 0 || a > 100)
			{
				throw new ArgumentException("Điểm số không được nhỏ hơn 0 hoặc lớn hơn 100");
			}
			else if (a >= 0 && a <= 50)
			{
				return "Xếp loại C";
			}
			else if (a >= 51 && a <= 80)
			{
				return "Xếp loại B";
			}
			else
			{
				return "Xếp loại A";
			}
		}
	}
}
