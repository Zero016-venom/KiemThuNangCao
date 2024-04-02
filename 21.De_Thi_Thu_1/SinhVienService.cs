using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.De_Thi_Thu_1
{
    public class SinhVienService
    {
        public List<SinhVien> _lstSinhViens;

        public SinhVienService()
        {
            _lstSinhViens = new List<SinhVien>();
        }

        public void AddSinhVien(SinhVien sinhVien)
        {
            _lstSinhViens.Add(sinhVien);

            if(sinhVien.Ten.Length > 50 || sinhVien.Ten.Length < 5)
            {
                throw new ArgumentException("Tên trong khoảng 5 - 50 ký tự");
            }

            if (sinhVien.Lop < 0 || sinhVien.Lop > 12)
            {
                throw new ArgumentException("Lớp từ 1 đến 12");
            }
        }

        public void DeleteSinhVien(string id)
        {
            var deleteSV = _lstSinhViens.Find(temp => temp.Id == id);
            if (deleteSV != null)
            {
                _lstSinhViens.Remove(deleteSV);
            }
        }
    }
}
