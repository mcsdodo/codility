using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class MissingInteger
	{
		public int solution(int[] A)
		{
			var positiveArray = A.Where(i => i > 0).ToArray();
			if (positiveArray.Length == 0) return 1;
			var max = positiveArray.Max();

			var cnt = Counting(positiveArray);

			for (int i = 1; i <= max; i++)
			{
				if (!cnt.ContainsKey(i)) return i;
			}
			return max + 1;
		}

		public Dictionary<int, bool> Counting(int[] array)
		{
			var cnt = new Dictionary<int, bool>();
			var len = array.Length;
			for (int i = 0; i < len; i++)
			{
				if (!cnt.ContainsKey(array[i]))
				{
					cnt.Add(array[i], true);
				}
			}
			return cnt;
		}

		[TestMethod]
		public void Test9()
		{
			//Arrange
			var arr = new int[100000];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = (int) Math.Pow(-1, i) * i;
			}

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void Test8()
		{
			//Arrange
			var arr = new[] {2, 3, int.MaxValue - 10, int.MaxValue};
			
			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void Test7()
		{
			//Arrange
			var arr = new[] {int.MinValue}; 
			
			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void Test6()
		{
			//Arrange
			var arr = new[] {int.MinValue, 0, 1, 2, int.MaxValue};
			
			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(3, res);
		}

		[TestMethod]
		public void Test5()
		{
			//Arrange
			var arr = new[] {1};

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(2, res);
		}

		[TestMethod]
		public void Test4()
		{
			//Arrange
			var arr = new[] {int.MinValue, int.MinValue + 10000, 0, 1, 2};

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(3, res);
		}

		[TestMethod]
		public void Test3()
		{
			//Arrange
			var arr = new[] {int.MinValue, int.MinValue + 10000, 0, 1, 2, 3, 4, 6};

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(5, res);
		}

		[TestMethod]
		public void Test2()
		{
			//Arrange
			var arr = new[] {int.MinValue, int.MinValue + 10000, 0, 10};

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(1, res);
		}

		[TestMethod]
		public void Test1()
		{
			//Arrange
			var arr = new [] {1, 3, 6, 4, 1, 2};

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(5, res);
		}
	}
}