using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class PermMissingElem
	{
		public int solution(int[] A)
		{
			double sum = 0;
			double length = (double)A.Length;

			for (int i = 0; i < length; i++)
			{
				sum += A[i];
			}

			var supposedSum = (length + 1) * ((double)(length + 2) / 2);

			return (int)(supposedSum - sum);
		}

		int[] GetArray(int length, int missing)
		{
			List<int> list = new List<int>();
			for (int i = 1; i <= length; i++)
			{
				if (i != missing) list.Add(i);
			}
			list.Reverse();
			return list.ToArray();
		}

		[TestMethod]
		public void Test7()
		{
			//Arrange
			var arr = GetArray(1000000, 5);

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(5, res);

		}

		[TestMethod]
		public void Test6()
		{
			//Arrange
			var arr = GetArray(100000, 99999);

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(99999, res);

		}

		[TestMethod]
		public void Test5()
		{
			//Arrange
			var arr = GetArray(5000, 5);

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(5, res);
		}

		[TestMethod]
		public void Test4()
		{
			//Arrange
			var arr = GetArray(10,4);
			
			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(4, res);

		}

		[TestMethod]
		public void Test3()
		{
			//Arrange
			var arr = GetArray(10, 9);

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(9, res);
		}

		[TestMethod]
		public void Test2()
		{
			//Arrange
			var arr = new [] {1,3};

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(2,res);
		}

		[TestMethod]
		public void Test1() 
		{
			//Arrange
			var arr = new [] {2, 3, 1, 5};

			//Act
			var res = solution(arr);

			//Assert
			Assert.AreEqual(4,res);
		}
	}
}
