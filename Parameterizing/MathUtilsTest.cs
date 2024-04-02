using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterizing
{
	[TestFixture]
	public class TestDemo
	{

		private MathUtils btap;

		[SetUp]
		public void SetUp()
		{
			btap = new MathUtils();
		}

		[Test]
		public void SumOf2Number()
		{
			
		}
	}
}
