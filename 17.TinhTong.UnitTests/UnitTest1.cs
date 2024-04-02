namespace _17.TinhTong.UnitTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{

		}
		// Phân vùng tương đương
		// Vùng giá trị âm (vùng ko hợp lệ)
		[Test]
		public void Test_NumberCorrect1()
		{
			int a = 99;
			int b = 1;

			Assert.That(a, Is.InRange(0, 100));
			Assert.That(b, Is.InRange(0, 100));

			int actual = TinhTong.PTinhTong(a, b);
			int expect = 100;

			Assert.AreEqual(actual, expect);
		}

		[Test]
		public void Test_NumberCorrect2()
		{
			int a = -99;
			int b = -1;

			if ((a >= 0 && a <= 100) && (b >= 0 && b <= 100))
			{
				int actual = TinhTong.PTinhTong(a, b);
				int expect = 100;

				Assert.AreEqual(actual, expect);
			}
			else
			{
				Assert.IsFalse(true);
			}		
		}
	}
}