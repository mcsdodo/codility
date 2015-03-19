using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class FrogJmp
	{
		int solution(int X, int Y, int D)
		{
			if ((Y - X) < D && Y != X) return 1;
			var mod = (Y - X) % D;
			var result = (double)((Y - X) + mod) / D;
			
			return (int)Math.Ceiling(result);
		}

		[TestMethod]
		public void Test10()
		{
			//Arrange
			var X = 1;
			var Y = 21;
			var D = 10;

			//Act


			//Assert
			Assert.AreEqual(2, solution(X, Y, D));
		}

		[TestMethod]
		public void Test9()
		{
			//Arrange
			var X = 1;
			var Y = 12;
			var D = 10;

			//Act


			//Assert
			Assert.AreEqual(2, solution(X, Y, D));
		}

		[TestMethod]
		public void Test8()
		{
			//Arrange
			var X = 1;
			var Y = 10;
			var D = 10;

			//Act


			//Assert
			Assert.AreEqual(1, solution(X, Y, D));
		}

		[TestMethod]
		public void Test7()
		{
			//Arrange
			var X = 1;
			var Y = 2;
			var D = 100000;

			//Act


			//Assert
			Assert.AreEqual(1, solution(X, Y, D));
		}

		[TestMethod]
		public void Test6()
		{
			//Arrange
			var X = 1;
			var Y = 1;
			var D = 100000;

			//Act


			//Assert
			Assert.AreEqual(0, solution(X, Y, D));
		}

		[TestMethod]
		public void Test5()
		{
			//Arrange
			var X = 1;
			var Y = 1;
			var D = 1;

			//Act


			//Assert
			Assert.AreEqual(0, solution(X, Y, D));
		}

		[TestMethod]
		public void Test4()
		{
			//Arrange
			var X = 1;
			var Y = 1000000000;
			var D = 1;

			//Act


			//Assert
			Assert.AreEqual(999999999, solution(X, Y, D));
		}

		[TestMethod]
		public void Test3()
		{
			//Arrange
			var X = 10;
			var Y = 85;
			var D = 30;

			//Act


			//Assert
			Assert.AreEqual(3, solution(X, Y, D));
		}

		[TestMethod]
		public void Test2()
		{
			//Arrange
			var X = 1;
			var Y = 3;
			var D = 1;

			//Act


			//Assert
			Assert.AreEqual(2, solution(X, Y, D));
		}


		[TestMethod]
		public void Test1()
		{
			var X = 1;
			var Y = 2;
			var D = 1;

			Assert.AreEqual(1, solution(X,Y,D));
		}
	}
}
