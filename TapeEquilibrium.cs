using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class TapeEquilibrium
	{
		public int solution(int[] A)
		{
			var totalSum = A.ToList().Sum();
			var minDif = int.MaxValue;

			var prevSum = 0;

			for (int i = 0; i < A.Length-1; i++)
			{
				prevSum += A[i];
				var rest = totalSum - prevSum;
				var dif = Math.Abs(prevSum - rest);
				minDif = dif < minDif ? dif : minDif;
			}
			return minDif;
		}

		public int NxNsol(int[] A)
		{
			var minDif = int.MaxValue;
			for (int i = 1; i < A.Length; i++)
			{
				var preSum = A.Take(i).Sum();
				var postSum = A.Skip(i).Sum();
				var dif = Math.Abs(preSum - postSum);
				minDif = dif < minDif ? dif : minDif;
			}
			return minDif;
		}

		[TestMethod]
		public void Test5()
		{
			//Arrange
			var arr = new[] { 1, 2, 3, 5, 8 };

			//Act
			var res = solution(arr);

			//Assert
			Debug.WriteLine(NxNsol(arr));
			Assert.AreEqual(3, res);
		}

		[TestMethod]
		public void Test1000()
		{
			//Arrange
			var arr = new[] { -1000, 1, 100, 101 };

			//Act
			var res = solution(arr);

			//Assert
			Debug.WriteLine(NxNsol(arr));
			Assert.AreEqual(1000, res);
		}

		[TestMethod]
		public void Test1001()
		{
			//Arrange
			var arr = new[] { -1000, 1 };

			//Act
			var res = solution(arr);

			//Assert
			Debug.WriteLine(NxNsol(arr));
			Assert.AreEqual(1001, res);
		}

		[TestMethod]
		public void Test1()
		{
			//Arrange
			var arr = new[] { 3, 1, 2, 4, 3 };

			//Act
			var res = solution(arr);

			//Assert
			Debug.WriteLine(NxNsol(arr));
			Assert.AreEqual(1, res);
		}
	}
}