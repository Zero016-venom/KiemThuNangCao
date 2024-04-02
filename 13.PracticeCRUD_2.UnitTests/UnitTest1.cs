namespace _13.PracticeCRUD_2.UnitTests
{
	[TestFixture]
	public class Tests
	{
		public XeOto _oto;
		public XeOtoMangager _otoMangager;

		[SetUp]
		public void Setup()
		{
			_otoMangager = new XeOtoMangager();
		}

		[Test]
		public void Test_AddOto()
		{
			_oto = new XeOto(1, "Xe Porsche Cayenne S", 7700000000, "None");

			_otoMangager.AddOto(_oto);

			Assert.Contains(_oto, _otoMangager._lstOto);
		}

		[Test]
		public void Test_UpdateOto()
		{
			_oto = new XeOto(1, "Xe Porsche Cayenne S", 7700000000, "None");

			_otoMangager.AddOto(_oto);

			string newTen = "abc";
			decimal newGia = 100;

			_otoMangager.UpdateOto(1, newGia, newTen);

			Assert.AreEqual(newTen, _oto.Ten);
			Assert.AreEqual(newGia, _oto.Gia);
		}

		[Test]
		public void Test_DeleteOto()
		{
			_oto = new XeOto(1, "Xe Porsche Cayenne S", 7700000000, "None");

			_otoMangager.AddOto(_oto);
			_otoMangager.DeleteOto(1);

			Assert.IsFalse(_otoMangager._lstOto.Contains(_oto));
		}

		[Test]
		public void Test_DeleteAllOto()
		{
			_oto = new XeOto(1, "Xe Porsche Cayenne S", 7700000000, "None");
			_oto = new XeOto(2, "Xe Porsche Cayenne S", 7700000000, "None");

			_otoMangager.AddOto(_oto);

			Assert.IsFalse(_otoMangager._lstOto.Contains(_oto));
		}
	}
}