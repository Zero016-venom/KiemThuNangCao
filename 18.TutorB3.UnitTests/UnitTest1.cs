namespace _18.TutorB3.UnitTests
{
	public class Tests
	{
		DanhgiaGrader _danhGia;
		[SetUp]
		public void Setup()
		{
			_danhGia = new DanhgiaGrader();
		}

		[Test]
		public void Test_XepLoaiC()
		{
			int a = 49;
			string expected = "Xếp loại C";

			Assert.AreEqual(expected, _danhGia.XepLoai(a));
			Assert.AreEqual(_danhGia.XepLoai(a), expected);
		}

		[Test]
		public void Test_XepLoaiA()
		{
			int a = 100;
			string expected = "Xếp loại A";

			//Assert.AreEqual(expected, _danhGia.XepLoai(a));
			Assert.AreEqual(_danhGia.XepLoai(a), expected);
		}
	}
}