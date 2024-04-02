using _20.LuyenDe.UnitTests;

namespace _21.De_Thi_Thu_1.UnitTests
{
    public class Tests
    {
        public PhepTinh _phepTinh;
        public StudentAverage _studentAverage;
        public SinhVien _sinhVien;
        public SinhVienService _sinhVienService;

        [SetUp]
        public void Setup()
        {
            _phepTinh = new PhepTinh();
            _studentAverage = new StudentAverage();
            _sinhVienService = new SinhVienService();
        }

        [Test]
        [TestCase(9, 1, 7)]
        [TestCase(10, 1, 9)]
        [TestCase(11, 1, 10)]
        [TestCase(8, 0, 8)]
        [TestCase(8, -1, 7)]
        public void Test1_Hieu(int a, int b, int c)
        {
            if ((a >= 0 && a <= 10) && (b >= 0 && b <= 10))
            {
                int actual = _phepTinh.TinhHieu(a, b);

                Assert.AreEqual(actual, c);
            }
            else
            {
                Assert.IsFalse(true);
            }
        }

        [Test]
        [TestCase(9, 1, 9)]
        [TestCase(10, 1, 10)]
        [TestCase(10, 2, 5)]
        [TestCase(15, 3, 5)]
        [TestCase(8, 0, 0)]
        public void Test_Thuong(int a, int b, int c)
        {
            if ((a >= 0 && a <= 10) && (b >= 0 && b <= 10))
            {
                int actual = _phepTinh.TinhThuong(a, b);

                Assert.AreEqual(actual, c);
            }
            else if (a == 0 || b == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                Assert.IsFalse(true);
            }
        }

        [Test]
        public void Test_XepLoai()
        {
            double averageScore = 101;

            string result = _studentAverage.getAverageRank(averageScore);

            Assert.That(result, Is.EqualTo("Xếp loại A"));
        }

        [Test]
        public void Test_XepLoaiA()
        {
            double averageScore = 100;

            string result = _studentAverage.getAverageRank(averageScore);

            Assert.That(result, Is.EqualTo("Xếp loại A"));
        }

        [Test]
        public void Test1_Add()
        {
            _sinhVien = new SinhVien("1", "Viet Anh", 12, "anhhvph31156");

            _sinhVienService.AddSinhVien(_sinhVien);

            Assert.IsTrue(_sinhVienService._lstSinhViens.Contains(_sinhVien));
        }

        [Test]
        public void Test2_Add()
        {
            _sinhVien = new SinhVien("1", "Via", 12, "anhhvph31156");

            _sinhVienService.AddSinhVien(_sinhVien);

            Assert.IsTrue(_sinhVienService._lstSinhViens.Contains(_sinhVien));
        }

        [Test]
        public void Test3_Add()
        {
            _sinhVien = new SinhVien("1", "ViaViaViaVia ViaViaViaViaViaViaViaViaViaViaViaViaViaViaViaVia ViaViaViaViaViaViaViaViaViaViaViaViaViaViaViaVia ViaViaViaViaViaViaViaViaViaViaViaViaViaViaViaVia", 12, "anhhvph31156");

            _sinhVienService.AddSinhVien(_sinhVien);

            Assert.IsTrue(_sinhVienService._lstSinhViens.Contains(_sinhVien));
        }

        [Test]
        public void Test4_Add()
        {
            _sinhVien = new SinhVien("1", "Vanh", -1, "anhhvph31156");

            _sinhVienService.AddSinhVien(_sinhVien);

            Assert.IsTrue(_sinhVienService._lstSinhViens.Contains(_sinhVien));
        }

        [Test]
        public void Test5_Add()
        {
            _sinhVien = new SinhVien("1", "Vanh", 12, "anhhvph31156");

            _sinhVienService.AddSinhVien(_sinhVien);

            Assert.IsTrue(_sinhVienService._lstSinhViens.Contains(_sinhVien));
        }

        [Test]
        public void Test1_Delete()
        {
            _sinhVien = new SinhVien("1", "Vanh", 12, "anhhvph31156");

            _sinhVienService.AddSinhVien(_sinhVien);
            _sinhVienService.DeleteSinhVien("1");

            Assert.IsTrue(_sinhVienService._lstSinhViens.Contains(_sinhVien));
        }

        [Test]
        public void Test2_Delete()
        {
            _sinhVien = new SinhVien("1", "Vanh", 12, "anhhvph31156");

            _sinhVienService.AddSinhVien(_sinhVien);
            _sinhVienService.DeleteSinhVien("2");

            Assert.IsTrue(_sinhVienService._lstSinhViens.Contains(_sinhVien));
        }

        [Test]
        public void Test3_Delete()
        {
            _sinhVien = new SinhVien("1", "Vanh", 12, "anhhvph31156");

            _sinhVienService.AddSinhVien(_sinhVien);
            _sinhVienService.DeleteSinhVien("");

            Assert.IsTrue(_sinhVienService._lstSinhViens.Contains(_sinhVien));
        }

        [Test]
        public void  Test1_TinhTrungBinhCong()
        {
            // Arrange
            List<double> numbers = new List<double> { 1, 2, 3 };

            // Act
            double result = _phepTinh.TrungBinhCong(numbers);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 15)]
        [TestCase(10, 55)]
        [TestCase(100, 5050)]
        public void Test_SumFromOneToN(int n, int expectedSum)
        {
            var actualSum = _phepTinh.SumTu1DenN(n);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}