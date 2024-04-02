using System.Text.RegularExpressions;

namespace _16.Lab5.UnitTests
{
	[TestFixture]
	public class Tests
	{
		public SanPham? _sanPham;
		public SanPhamManager _sanPhamManager;

		[SetUp]
		public void Setup()
		{
			_sanPhamManager = new SanPhamManager();
		}

		[Test]
		public void Test_AddSanPham_WithQuantity()
		{
			_sanPham = new SanPham("SP01", "ABC", "Khan giay", 6000, "Trang", "10", 2);

			if(_sanPham.soLuong > 0 && _sanPham.soLuong < 100)
			{
				_sanPhamManager.AddSanPham(_sanPham);
			}

			Assert.Contains(_sanPham, _sanPhamManager._lstSanPhams);
		}

		[Test]
		public void Test_UpdateSanPham_WithMaSPStartSP()
		{
			SanPham _sanPham1 = new SanPham("01", "SP01", "Khan giay", 6000, "Trang", "10", 2);
			SanPham _sanPham2 = new SanPham("02", "SP02", "Khan giay", 8000, "Trang", "10", 2);

			_sanPhamManager.AddSanPham(_sanPham1);
			_sanPhamManager.AddSanPham(_sanPham2);

			string newMaSP = "SP05";

            /*
            List<string> _lstMaSP = new List<string>();

            foreach (var item in _sanPhamManager._lstSanPhams)
			{
				_lstMaSP.Add(item.maSanPham);
			}
			
			if(!_lstMaSP.Contains(newMaSP))
			{
				_sanPham1.maSanPham = newMaSP;
			}
			*/

            var isDup = _sanPhamManager._lstSanPhams.FirstOrDefault(s => s.maSanPham == newMaSP);

            if (isDup == null)
            {
                _sanPham1.maSanPham = newMaSP;
            }

            Assert.AreEqual(_sanPham1.maSanPham, newMaSP);
		}
	}
}