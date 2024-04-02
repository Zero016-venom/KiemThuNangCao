namespace _20.LuyenDe.UnitTests
{
    public class Tests
    {
        public Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        [TestCase(4, 5, 9)]
        [TestCase(-4, -5, -9)]
        [TestCase(11, 12, 23)]
        [TestCase(1, 5, 6)]
        [TestCase(10, 4, 14)]
        public void TinhTong(int a, int b, int c)
        {
            if ((a >= -10 && a <= 10) && (b >= -10 && b <= 10))
            {
                int actual = _math.Tong(a, b);

                Assert.AreEqual(actual, c);
            }
            else
            {
                Assert.IsFalse(true);
            }
        }

        [Test]
        [TestCase(4, 5, 1)]
        [TestCase(-4, -5, 1)]
        [TestCase(11, 12, -1)]
        [TestCase(1, 5, -4)]
        [TestCase(10, 4, 6)]
        public void TinhHieu(int a, int b, int c)
        {
            if ((a >= -10 && a <= 10) && (b >= -10 && b <= 10))
            {
                int actual = _math.Hieu(a, b);

                Assert.AreEqual(actual, c);
            }
            else
            {
                Assert.IsFalse(true);
            }
        }

        [Test]
        [TestCase(4, 5, 20)]
        [TestCase(-4, -5, 20)]
        [TestCase(11, 12, 100)]
        [TestCase(1, 5, 5)]
        [TestCase(10, 4, 40)]
        public void TinhTich(int a, int b, int c)
        {
            if ((a >= -10 && a <= 10) && (b >= -10 && b <= 10))
            {
                int actual = _math.Tich(a, b);

                Assert.AreEqual(actual, c);
            }
            else
            {
                Assert.IsFalse(true);
            }
        }

        [Test]
        public void TinhTrungBinhCong()
        {
            // Arrange
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5 };

            // Act
            double result = _math.TrungBinhCong(numbers);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TinhTrungBinhCong_DanhSachRong()
        {
            // Arrange
            List<double> numbers = new List<double>();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _math.TrungBinhCong(numbers));
        }

        [Test]
        public void TestTruyXuatPhanTu()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5 };
            int index = 2;

            // Act
            int actual = arr[index];

            // Assert
            Assert.AreEqual(3, actual);
        }
    }
}