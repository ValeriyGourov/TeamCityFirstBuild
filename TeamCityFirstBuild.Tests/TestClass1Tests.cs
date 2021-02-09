using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TeamCityFirstBuild.Tests
{
	[TestClass]
	public class TestClass1Tests
	{
		[TestMethod("Тестовый метод 1")]
		public void TestMethod1Test()
		{
			// Arrange.
			TestClass1 testClass1 = new();
			const int
				arg1 = 4,
				arg2 = 5,
				expected = 9;

			// Act.
			int actual = testClass1.TestMethod1(arg1, arg2);

			// Assert.
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("Тестовый метод 2")]
		[DataRow(4, 5, 9)]
		[DataRow(5, 5, 10)]
		public void TestMethod1Test(int arg1, int arg2, int expected)
		{
			// Arrange.
			TestClass1 testClass1 = new();

			// Act.
			int actual = testClass1.TestMethod1(arg1, arg2);

			// Assert.
			Assert.AreEqual(expected, actual);
		}
	}
}