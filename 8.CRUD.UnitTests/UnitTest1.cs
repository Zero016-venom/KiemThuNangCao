namespace _8.CRUD.UnitTests
{
	public class Tests
	{
		public NhanVienManager _nhanVienManager;
		public NhanVien _nv;

		[SetUp]
		public void Setup()
		{
			_nhanVienManager = new NhanVienManager();
		}

		[Test]
		public void Test_AddNV()
		{
			_nv = new NhanVien(10, "Test");

			_nhanVienManager.AddNhanVien(_nv);

			Assert.Contains(_nv, _nhanVienManager._lstNV);
		}

		[Test]
		public void Test_UpdateNV()
		{
			_nv = new NhanVien(10, "Test");

			_nhanVienManager.AddNhanVien(_nv);
			_nhanVienManager.UpdateNhanVien(10, "Test2");

			Assert.Contains(_nv, _nhanVienManager._lstNV);
		}

		[Test]
		public void Test_DeleteNV()
		{
			_nv = new NhanVien(10, "Test");

			_nhanVienManager.AddNhanVien(_nv);
			_nhanVienManager.RemoveNhanVien(10);

			//Assert.Contains(_nv, _nhanVienManager._lstNV);
			Assert.IsFalse(_nhanVienManager._lstNV.Contains(_nv));
		}
	}
}