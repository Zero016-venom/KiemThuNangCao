using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.LuyenDe.UnitTests
{
    public class StudentAverage
    {
        public string getAverageRank(double averageScore)
        {
            if (averageScore < 0 || averageScore > 100)
            {
                throw new ArgumentException("Điểm không hợp lệ ! (Điểm phải > 0 và < 100)");
            }

            if (averageScore >= 71)
            {
                return "Xếp loại A";
            }
            else if (averageScore >= 41)
            {
                return "Xếp loại B";
            }
            else
            {
                return "Xếp loại C";
            }

        }
    }
}
