using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class CountingExcercise
	{
		public bool IsSwappable(int[] a, int[] b, int max)
		{
			var sumA = a.Sum();
			var sumB = b.Sum();

			var cntA = CountingImpl.Counting(a, max);

			var dif = sumA - sumB;
			if (dif % 2 != 0) return false;
			dif = dif / 2;

			for (int i = 0; i < b.Length; i++)
			{
				var switchFromB = b[i];

				var switchFromA = switchFromB + dif;

				if (switchFromA >= 0 && switchFromA <= max && cntA[switchFromA] > 0)
				{
					Debug.WriteLine(string.Format("Should swap {0} for {1}", switchFromA, switchFromB));
					return true;
				}
			}

			return false;
		}

		[TestMethod]
		public void Test4_NotDivisibleBy2()
		{
			//Arrange
			var a = new[] { 2, 3, 3 };
			var b = new[] { 1, 2 };

			//Act

			//Assert
			Assert.IsFalse(IsSwappable(a,b,3));
		}


		[TestMethod]
		public void Test3()
		{
			//Arrange
			var a = new[] { 1, 3, 3 };
			var b = new[] { 1, 2, 2 };

			//Act

			//Assert
			Assert.IsTrue(IsSwappable(a, b, 3));
			Assert.IsTrue(IsSwappable(b, a, 3));

		}

		[TestMethod]
		public void Test2()
		{
			//0 for 6

			//Arrange
			var a = new[] { 2, 2, 0 };
			var b = new[] { 10, 6 };

			//Act

			//Assert
			Assert.IsTrue(IsSwappable(a, b, 10));
			Assert.IsTrue(IsSwappable(b, a, 10));
		}

		[TestMethod]
		public void Test1()
		{
			//Arrange
			var a = new[] { 1, 2, 3, 4 };
			var b = new[] { 0, 2 };

			//Act

			//Assert
			Assert.IsTrue(IsSwappable(a, b, 4));
			Assert.IsTrue(IsSwappable(b, a, 4));
		}

	}
}