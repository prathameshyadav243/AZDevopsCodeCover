using System;
using System.Collections.Generic;
using System.Text;

namespace AzureDevops_CodeCoverage
{
	public class Calculator
	{
		public bool IsPositiveNumber(int a, int b)
		{
			return (a + b) > 0;
		}

		public bool IsNegativeNumber(int a, int b)
		{
			return (a - b) < 0;
		}
	}
}
