using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CRUD
{
	public class NhanVienManager
	{
		public static void Main(string[] args)
		{

		}

		public List<NhanVien> _lstNV = new List<NhanVien>();

		public void AddNhanVien(NhanVien nhanVien)
		{
			_lstNV.Add(nhanVien);
		}

		public void UpdateNhanVien(int id, string newName)
		{
			var temp = _lstNV.FirstOrDefault(a => a.ID == id);

			if (temp != null)
			{
				temp.Name = newName;
			}
		}

		public void RemoveNhanVien(int id)
		{
			_lstNV.RemoveAll(a => a.ID == id);
		}
	}
}
