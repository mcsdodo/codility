using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class PrefixSumsImpl
	{
		public int[] PrefixSums(int[] A)
		{
			var len = A.Length;
			var res = new int[len + 1];
			for (int i = 1; i <= len; i++)
			{
				res[i] = res[i - 1] + A[i - 1];
			}
			return res;
		}

		public int[] SuffixSums(int[] A)
		{
			var len = A.Length;
			var res = new int[len + 1];
			
			for (int i = 1; i <= len; i++)
			{
				res[i] = res[i - 1] + A[len - i];
			}

			return res;
		}

		public int Total(int[] P, int X, int Y)
		{
			return P[Y + 1] - P[X];
		}

		[TestMethod]
		public void Test1()
		{
			//Arrange
			var arr = new[] {1, 2, 3, 4, 5};

			//Act
			var res = PrefixSums(arr);

			//Assert
			CollectionAssert.AreEqual(new[] {0, 1, 3, 6, 10, 15}, res);
		}

		[TestMethod]
		public void Test2()
		{
			//Arrange
			var arr = new[] {1, 2, 3, 4, 5};

			//Act
			var res = SuffixSums(arr);

			//Assert
			CollectionAssert.AreEqual(new[] {0, 5, 9, 12, 14, 15}, res);
		}

		[TestMethod]
		public void Test3()
		{
			//Arrange
			var arr = new[] { 1, 2, 3, 4, 5 };

			//Act
			var pre = PrefixSums(arr);
			var res = Total(pre, 2, 3);

			//Assert
			Assert.AreEqual(7, res);
		}
	}
}