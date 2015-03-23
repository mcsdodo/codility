using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility
{
	[TestClass]
	public class CountingImpl
	{
		public static int[] Counting(int[] array, int m)
		{
			var len = array.Length;
			var cnt = new int[m + 1];
			for (int i = 0; i < len; i++)
			{
				cnt[array[i]] += 1;
			}
			return cnt;
		}

		[TestMethod]
		public void Counting_ShouldCount()
		{
			//Arrange
			var arr = new[] { 1, 1, 2, 3, 0 };

			//Act
			var cnt = Counting(arr, 3);

			//Assert
			CollectionAssert.AreEqual(new[] { 1, 2, 1, 1 }, cnt);
		}
	}
}
