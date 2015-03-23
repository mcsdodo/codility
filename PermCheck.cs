using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class PermCheck
	{
		public int solution(int[] A)
		{
			var max = A.Max();
			if (max > A.Length) return 0;

			var cnt = CountingImpl.Counting(A, max);
			for (int i = 1; i < cnt.Length; i++)
			{
				if (cnt[i] != 1) return 0;
			}
			return 1;
		}

		[TestMethod]
		public void Test7()
		{
			//Arrange
			var arr = new int[100000];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = 1000000000 - i;
			}

			//Act
			var perm = solution(arr);

			//Assert
			Assert.AreEqual(0, perm);
		}

		[TestMethod]
		public void Test6()
		{
			//Arrange
			var arr = new int[100000];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = 100001 - i;
			}

			//Act
			var perm = solution(arr);

			//Assert
			Assert.AreEqual(0, perm);
		}

		[TestMethod]
		public void Test5()
		{
			//Arrange
			var arr = new int[100000];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = 100000 - i;
			}

			//Act
			var perm = solution(arr);

			//Assert
			Assert.AreEqual(1, perm);
		}

		[TestMethod]
		public void Test4()
		{
			//Arrange
			var arr = new int[100000];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = i+1;
			}

			//Act
			var perm = solution(arr);

			//Assert
			Assert.AreEqual(1, perm);
		}

		[TestMethod]
		public void Test3()
		{
			//Arrange
			var arr = new[] {1};
			
			//Act
			var perm = solution(arr);

			//Assert
			Assert.AreEqual(1, perm);
		}

		[TestMethod]
		public void Test2()
		{
			//Arrange
			var arr = new[] {4, 1, 3};

			//Act
			var perm = solution(arr);

			//Assert
			Assert.AreEqual(0, perm);
		}

		[TestMethod]
		public void Test1()
		{
			//Arrange
			var arr = new[] {4, 1, 3, 2};

			//Act
			var perm = solution(arr);

			//Assert
			Assert.AreEqual(1, perm);
		}
	}
}