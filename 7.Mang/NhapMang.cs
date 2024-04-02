using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Mang
{
	public class NhapMang
	{
		public static int GetElementAtIndex(int[] array, int index)
		{
			if (index < 0 || index >= array.Length)
			{
				throw new IndexOutOfRangeException("Chỉ mục nằm ngoài phạm vi !");
			}
			
			return array[index];
		}
	}
}
