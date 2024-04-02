using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SinhVien
{
	public class SV_CRUD
	{
		public List<SinhVien> _lstSV = new List<SinhVien>();

		public void AddSV(SinhVien sv)
		{
			_lstSV.Add(sv);
		}

		public void UpdateSV(int id, string idStudent, string newName) 
		{
			var temp = _lstSV.FirstOrDefault(a=>a.ID == id);

			if(temp != null)
			{
				temp.MaSV = idStudent;
				temp.Ten = newName;
			}
		}

		public void DelSV(int id)
		{
			_lstSV.RemoveAll(a => a.ID == id);
		}
	}
}
