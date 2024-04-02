using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _9.SinhVien.UnitTests
{
	public class Tests
	{
		public SinhVien _sv;
		public SV_CRUD svCRUD;

		[SetUp]
		public void Setup()
		{
			svCRUD = new SV_CRUD();
		}

		[Test]
		public void Test_AddSV()
		{
			_sv = new SinhVien(1, "PH31156", "Vanh");

			svCRUD.AddSV(_sv);

			Assert.Contains(_sv, svCRUD._lstSV);
		}

		[Test]
		public void Test_AddSV_Null_Ten()
		{
			_sv = new SinhVien(1, "PH31156", "");
			if(_sv.Ten != "")
			{
				svCRUD.AddSV(_sv);
			}

			Assert.IsFalse(svCRUD._lstSV.Contains(_sv));
		}

		[Test]
		public void Test_AddSV_GreaterThan_25Characters()
		{
			_sv = new SinhVien(1, "PH31156", "testtesttesttesttesttesttesttesttesttesttesttesttest");
			if (_sv.Ten.Length <= 25)
			{
				svCRUD.AddSV(_sv);
			}

			Assert.IsFalse(svCRUD._lstSV.Contains(_sv));
		}

		[Test]
		public void Test_AddSV_Enough_25Characters()
		{
			_sv = new SinhVien(1, "PH31156", "test");
			if (_sv.Ten.Length <= 25)
			{
				svCRUD.AddSV(_sv);
			}

			Assert.IsFalse(svCRUD._lstSV.Contains(_sv));
		}

		[Test]
		public void Test_AddSV_NotWith_Number()
		{
			_sv = new SinhVien(1, "PH31156", "test");

			if (!Regex.IsMatch(_sv.Ten, "\\d"))
			{
				svCRUD.AddSV(_sv);
			}

			Assert.IsTrue(svCRUD._lstSV.Contains(_sv));
		}

		[Test]
		public void Test_MaSV_StartWith_PH1()
		{
			_sv = new SinhVien(1, "PH31156", "test");
			if (_sv.MaSV.StartsWith("PH"))
			{
				svCRUD.AddSV(_sv);
			}
			//if (Regex.IsMatch(_sv.MaSV, "^PH"))
			//{
			//	svCRUD.AddSV(_sv);
			//}
			Assert.IsTrue(svCRUD._lstSV.Contains(_sv));
		}

		[Test]
		public void Test_UpdateSV()
		{
			_sv = new SinhVien(1, "PH31156", "Vanh");

			svCRUD.AddSV(_sv);

			string newIdStudent = "PH55555";
			string newName = "Viet Anh";

			svCRUD.UpdateSV(1, newIdStudent, newName);

			//Assert.AreEqual(_sv.ID, newIdStudent);
		}

		[Test]
		public void Test_DelSV()
		{
			_sv = new SinhVien(1, "PH31156", "Vanh");

			svCRUD.AddSV(_sv);
			svCRUD.DelSV(1);

			Assert.IsFalse(svCRUD._lstSV.Contains(_sv));
		}
	}
}