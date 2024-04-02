namespace _6.TrungBinhCong.UnitTests
{
	[TestFixture]
	public class AveCalTests
	{
		[Test]
		public void AveCal_BadException_WhenListIsEmpty()
		{
			// Arrange
			List<int> emptyList = new List<int>();

			// Act & Assert
			Assert.Throws<ArithmeticException>(() => AveCal.TBC(emptyList));
		}

		[Test]
		public void AvaCal_CorrectException_WhenListIsNotEmpty()
		{
			// Arrange
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
			double expected = 3.0;

			// Act
			double actual = AveCal.TBC(numbers);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}