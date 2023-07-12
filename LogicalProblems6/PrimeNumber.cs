using System;
namespace LogicalProblems6
{
	public class PrimeNumber
	{
		public int IsPrime(int n)
		{
			if(n == 1 || n==0) {
				return -1;
			}

			for(int i =2; i<=Math.Sqrt(n); i++)
			{
				if(n%i == 0)
				{
					return 0;
				}
			}
			return 1;
		}
	}
}

