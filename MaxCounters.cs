using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class MaxCounters
	{
		public int[] solution(int N, int[] A)
		{
			var cnt = new int[N];
			var max = 0;
			var maxThresh = 0;

			for (int i = 0; i < A.Length; i++)
			{
				var elm = A[i];
				if (1 <= elm && elm <= N)
				{
					if (cnt[elm - 1] < maxThresh) cnt[elm - 1] = maxThresh;
					cnt[elm - 1] += 1;
					max = cnt[elm - 1] > max ? cnt[elm - 1] : max;
				}

				if (elm == N + 1)
				{
					// M*N complexity
//					for (int j = 0; j < cnt.Length; j++)
//					{
//						cnt[j] = max;
//					}
					maxThresh = max;
				}
			}
			for (int i = 0; i < cnt.Length; i++)
			{
				cnt[i] = Math.Max(maxThresh, cnt[i]);
			}
			return cnt;
		}


		[TestMethod]
		public void Test7()
		{
			//Arrange
			var N = 100000;
			var list = new List<int>();
			for (int i = 0; i < 200000; i++)
			{
				if (i % 2 == 0) list.Add(100001);
				else list.Add(1);
			}

			//Act
			var res = solution(N, list.ToArray());

			//Assert
			var expected = Enumerable.Repeat(99999, 100000).ToArray();
			expected[0]++;
			CollectionAssert.AreEqual(expected, res);
		}

		[TestMethod]
		public void Test6()
		{
			//Arrange
			var N = 3;
			var A = new[] { 1, 4, 2, 4, 3, 4, 1, 1, 2};

			//Act
			var res = solution(N, A);

			//Assert
			CollectionAssert.AreEqual(new[] { 5, 4, 3 }, res);
		}

		[TestMethod]
		public void Test5()
		{
			//Arrange
			var N = 3;
			var A = new[] { 1, 4, 2, 4, 1 };

			//Act
			var res = solution(N, A);

			//Assert
			CollectionAssert.AreEqual(new[] { 3, 2, 2 }, res);
		}

		[TestMethod]
		public void Test4()
		{
			//Arrange
			var N = 5;
			var A = new[] { 1, 1, 1, 1, 6, 1, 1, 1, 1, 6, 1 };

			//Act
			var res = solution(N, A);

			//Assert
			CollectionAssert.AreEqual(new[] { 9, 8, 8, 8, 8 }, res);
		}

		[TestMethod]
		public void Test3()
		{
			//Arrange
			var N = 5;
			var A = new[] { 1, 1, 6, 6, 2 };

			//Act
			var res = solution(N, A);

			//Assert
			CollectionAssert.AreEqual(new[] { 2, 3, 2, 2, 2 }, res);
		}

		[TestMethod]
		public void Test22()
		{
			//Arrange
			var N = 5;
			var A = new[] { 1, 6, 6, 6, 6, 6, 6 };

			//Act
			var res = solution(N, A);

			//Assert
			CollectionAssert.AreEqual(new[] { 1, 1, 1, 1, 1 }, res);
		}

		[TestMethod]
		public void Test2()
		{
			//Arrange
			var N = 5;
			var A = new[] { 6, 6, 6, 6, 6, 6, 6 };

			//Act
			var res = solution(N, A);

			//Assert
			CollectionAssert.AreEqual(new[] { 0, 0, 0, 0, 0 }, res);
		}

		[TestMethod]
		public void Test1()
		{
			//Arrange
			var N = 5;
			var A = new[] { 3, 4, 4, 6, 1, 4, 4 };

			//Act
			var res = solution(N, A);

			//Assert
			CollectionAssert.AreEqual(new[] { 3, 2, 2, 4, 2 }, res);
		}
	}
}