using System;
namespace LogicalProblems6
{
	public class Number
	{
		public int ReverseNumber(int n)
		{
			int newNumber = 0;
			while(n>0)
			{
				int digit = n % 10;
				newNumber = newNumber*10 + digit;
				n = n / 10;
			}

			return newNumber;
		}
	}
}

