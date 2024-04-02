namespace _10.Tich3So.UnitTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
			PhepTinh phepTinh = new PhepTinh();
		}

		[Test]
		public void Test1()
		{
			// Arrange
			double a = 10;
			double b = 5;
			double c = 2;

			// Act
			double expected = a * b * c;
			double actual = 100;

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}