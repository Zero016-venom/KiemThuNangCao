using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PracticeCRUD_2
{
	public class XeOtoMangager
	{
		public List<XeOto> _lstOto;

        public XeOtoMangager()
        {
            _lstOto = new List<XeOto>();
        }

        public void AddOto(XeOto oto)
        {
            _lstOto.Add(oto);
        }

        public void UpdateOto(int ma, decimal newGia, string newTen)
        {
            var temp = _lstOto.FirstOrDefault(o => o.Ma == ma);
            if (temp != null)
            {
                temp.Gia = newGia;
                temp.Ten = newTen;  
            }
        }

        public void DeleteOto(int ma)
        {
            _lstOto.RemoveAll(o => o.Ma == ma);
        }

		public void DeleteAllOto()
		{
            foreach (var item in _lstOto)
            {
                _lstOto.Remove(item);
            }
		}
	}
}
