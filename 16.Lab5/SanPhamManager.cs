using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Lab5
{
	public class SanPhamManager
	{
		public List<SanPham> _lstSanPhams;

        public SanPhamManager()
        {
            _lstSanPhams = new List<SanPham>();
        }

        public void AddSanPham(SanPham sanPham)
        {
            _lstSanPhams.Add(sanPham);
        }

        public void UpdateSanPham(string iD, string newMaSP)
        {
			var temp = _lstSanPhams.FirstOrDefault(a=>a.id == iD);

            if (temp != null)
            {
                temp.maSanPham = newMaSP;
            }
		}
    }
}
