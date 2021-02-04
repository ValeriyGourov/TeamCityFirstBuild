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
	}
}