using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class FrogRiverOne
	{
		public int solution(int X, int[] A)
		{
			var allPositionsCoveredSum = (X*(X + 1))/2;

			var cnt = new int[X + 1];
			for (int minute = 0; minute < A.Length; minute++)
			{
				var position = A[minute];
				cnt[position] += 1;
				if (cnt[position] == 1) allPositionsCoveredSum -= position;
				if (allPositionsCoveredSum == 0) return minute;
			}
			return -1;
		}

		[TestMethod]
		public void Test6()
		{
			//Arrange
			var A = new[] { 4, 5, 3, 2, 1, 4 };
			var X = 5;

			//Act
			var res = solution(X, A);

			//Assert
			Assert.AreEqual(4, res);
		}

		[TestMethod]
		public void Test5()
		{
			//Arrange
			var A = new[] { 1, 2, 3, 4, 5 };
			var X = 5;

			//Act
			var res = solution(X, A);

			//Assert
			Assert.AreEqual(4, res);
		}

		[TestMethod]
		public void Test4()
		{
			//Arrange
			var list = new List<int>();
			for (int i = 1; i <= 100000; i++)
			{
				if (i == 5) continue;
				list.Add(i);
			}
			var X = 100000;

			//Act
			var res = solution(X, list.ToArray());

			//Assert
			Assert.AreEqual(-1, res);
		}

		[TestMethod]
		public void Test3()
		{
			//Arrange
			var list = new List<int>();
			for (int i = 1; i <= 100000; i++)
			{
				list.Add(i);
			}
			var X = 100000;

			//Act
			var res = solution(X, list.ToArray());

			//Assert
			Assert.AreEqual(99999, res);
		}

		[TestMethod]
		public void Test2()
		{
			//Arrange
			var A = new[] { 1, 2, 4, 5 };
			var X = 5;

			//Act
			var res = solution(X, A);

			//Assert
			Assert.AreEqual(-1, res);
		}

		[TestMethod]
		public void Test1()
		{
			//Arrange
			var X = 5;
			var A = new[] { 1, 3, 1, 4, 2, 3, 5, 4 };

			//Act
			var res = solution(X, A);

			//Assert
			Assert.AreEqual(6, res);
		}
	}
}