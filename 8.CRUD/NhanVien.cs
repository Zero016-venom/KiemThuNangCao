using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CRUD
{
	public class NhanVien
	{
        
		public NhanVien(int iD, string name)
		{
			ID = iD;
			Name = name;
		}

		public int ID { get; set; }
		public string Name { get; set; }
	}
}
