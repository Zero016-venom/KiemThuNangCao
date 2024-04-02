using System.Text.RegularExpressions;

namespace _19.TutorB3_2.UnitTests
{
	public class Tests
	{
		public DienThoai _dienThoai;
		public DienThoaiManager _dienThoaiManager;

		[SetUp]
		public void Setup()
		{
			_dienThoaiManager = new DienThoaiManager();
			_dienThoai = new DienThoai("01", "IPhone 15 PRM", 40000000, "Cao cấp");
			_dienThoai = new DienThoai("02", "IPhone 15 PRM", 40000000, "Cao cấp");
		}

		[Test]
		public void Test_AddDT_WithFirstCharacterUpcase()
		{
			if (Regex.IsMatch(_dienThoai.Ten.Substring(0, 1), "^[A-Z]"))
			{
				_dienThoaiManager.AddDienThoai(_dienThoai);
			}

			Assert.Contains(_dienThoai, _dienThoaiManager._lstDTs);
		}

		[Test]
		public void Test_FindDT_WithPrice()
		{
			_dienThoaiManager.AddDienThoai(_dienThoai);
			float giaTim = 40000000;

			List<DienThoai> result = _dienThoaiManager.FindDienThoai(giaTim);

			//Assert.AreEqual(giaTim, _dienThoai.Gia);
			//Assert.AreEqual(1, result.Count);
			Assert.IsTrue(result.Count > 0);
		}
	}
}