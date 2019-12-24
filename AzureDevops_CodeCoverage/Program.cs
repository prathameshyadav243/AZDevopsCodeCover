using System;
using System.Threading.Channels;

namespace AzureDevops_CodeCoverage
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calc = new Calculator();
			var addRes = calc.IsPositiveNumber(5, 4);
			var subRes = calc.IsNegativeNumber(7, 3);
			Console.WriteLine($"Add Result: {addRes} | SubtractResult: {subRes}");
		}
	}
}
