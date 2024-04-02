using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.De_Thi_Thu_1
{
    public class PhepTinh
    {
        public int TinhHieu(int a, int b)
        {
            return a - b;
        }

        public int TinhThuong (int a, int b)
        {
            return a / b;
        }

        public double TrungBinhCong(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("Danh sách không được rỗng");
            }

            foreach (var item in numbers)
            {
                if (item < -10 || item > 10)
                {
                    throw new ArgumentOutOfRangeException("Số trong danh sách nằm ngoài phạm vi từ -10 đến 10");
                }
            }

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Count;
        }

        public int SumTu1DenN(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("Giá trị của n phải lớn hơn hoặc bằng 1");
            }

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
