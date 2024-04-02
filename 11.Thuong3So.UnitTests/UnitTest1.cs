namespace _11.Thuong3So.UnitTests
{
	public class Test
	{
		[SetUp]
		public void Setup()
		{
			TinhThuong3So tinhThuong3So = new TinhThuong3So();
		}

		[Test]
		public void Test1()
		{
			// Arrange
			double a = 10.5;
			double b = 1;
			double c = 4;

			// Act
			double expected = a  / b / c;
			double actual = 2.625;

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
	
}