using System;

using Serilog;

namespace TeamCityFirstBuild
{
	class Program
	{
		static void Main(/*string[] args*/)
		{
			Log.Logger = new LoggerConfiguration().CreateLogger();
			Log.Information("No one listens to me!");

			Console.WriteLine("Hello World!");

			// Finally, once just before the application exits...
			Log.CloseAndFlush();


			ввввв
		}
	}
}
