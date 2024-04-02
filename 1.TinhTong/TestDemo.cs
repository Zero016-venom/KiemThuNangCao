using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TinhTong
{
	[TestFixture]
	public class TestDemo
	{
		[Test]
		public void SumOf2Number()
		{
			// Arrange
			int expect = 10;

			// Act
			int actual = Tong.TinhTong2So();

			// Assert
			Assert.Equals(expect, actual);
		}
	}
}
