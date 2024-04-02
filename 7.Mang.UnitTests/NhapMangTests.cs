namespace _7.Mang.UnitTests
{
	[TestFixture]
	public class NhapMangTests
	{
		[Test]
		public void GetElementAtIndex_ThrowsException_WhenIndexOutOfRange()
		{
			//Arrange 
			int[] array = { 3, 5, 6, 6, 9, 10 };
			int index = 11;

			Assert.Throws<IndexOutOfRangeException>(() => NhapMang.GetElementAtIndex(array, index));
			Assert.Throws<IndexOutOfRangeException>(() => NhapMang.GetElementAtIndex(array, array.Length));
		}

		[Test]
		public void GetElementAtIndex_ThrowsException_WhenIndexInRange()
		{
			int[] array = { 1, 2, 3, 5, 6 , 8, 9};
			int index = NhapMang.GetElementAtIndex(array, 2);
			int expected = 3;

			Assert.AreEqual(expected, index);
		}
	}
}