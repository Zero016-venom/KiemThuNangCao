using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TrungBinhCong
{
	public class AveCal
	{
		public static double TBC(List<int> numbers)
		{
			if (numbers.Count == 0)
			{
				throw new ArithmeticException("Danh sách không chứa phần tử nào.");
			}

			int sum = 0;
			foreach (int number in numbers)
			{
				sum += number;
			}

			return (double)sum / numbers.Count;
		}
	}
}
