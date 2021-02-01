using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace TeamCityFirstBuild
{
	public class TestClass1
	{
		public int MyProperty1 { get; set; }

		public int TestMethod1(int arg1, int arg2) => arg1 + arg2;

		[ExcludeFromCodeCoverage]
		public int TestMethod2(int arg1, int arg2) => arg1 - arg2;

		public async Task<int> TestMethod3(int arg1, int arg2) => await Task.FromResult<int>(arg1 % arg2);
	}
}
