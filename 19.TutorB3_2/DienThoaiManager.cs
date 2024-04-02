using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TutorB3_2
{
	public class DienThoaiManager
	{
		public List<DienThoai> _lstDTs;

		public DienThoaiManager()
		{
			_lstDTs = new List<DienThoai>();
		}

		public void AddDienThoai(DienThoai dienThoai)
		{
			_lstDTs.Add(dienThoai);

			//if (_lstDTs.Any(a => a.Id == newID))
			//{
			//	throw new ArgumentException("Id đã tồn tại");
			//}

			if (string.IsNullOrEmpty(dienThoai.Ten) || string.IsNullOrEmpty(dienThoai.Ten))
			{
				throw new ArgumentException("Tên điện thoại không được để trống");
			}

			//if (dienThoai.Ten.Any(char.IsPunctuation) || dienThoai.Ten.Any(char.IsDigit))
			//{
			//	throw new ArgumentException("Tên điện thoại không được chứa ký tự đặc biệt");
			//}

			if (dienThoai.Gia <= 0)
			{
				throw new ArgumentException("Giá điện thoại phải lớn hơn 0");
			}
		}

		public List<DienThoai> FindDienThoai(float giaTim)
		{
			return _lstDTs.FindAll(temp => temp.Gia == giaTim);
		}
	}
}
