using AzureDevops_CodeCoverage;
using NUnit.Framework;

namespace TestCases
{
	[TestFixture]
	public class CalculatorTest
	{
		private Calculator _calc;
		[SetUp]
		public void Setup()
		{
			_calc = new Calculator();
		}

		[Test]
		[TestCase(5, 6, true)]
		[TestCase(-9, 8, false)]
		public void Should_return_positive_result_valid_input(int a, int b, bool expectedResult)
		{
			bool addRes = _calc.IsPositiveNumber(a, b);
			Assert.AreEqual(expectedResult, addRes);
		}

		[Test]
		[TestCase(6, 5, false)]
		[TestCase(-9, 8, true)]
		public void Should_return_negative_result_valid_input(int a, int b, bool expectedResult)
		{
			bool addRes = _calc.IsNegativeNumber(a, b);
			Assert.AreEqual(expectedResult, addRes);
		}
	}
}