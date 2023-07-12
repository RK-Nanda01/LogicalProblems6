using System;
namespace LogicalProblems6
{
	public class PerfectNumber
	{
		public int IsPerfect(int n)
		{
			int sum = 0;
			for(int i = 1; i<=Math.Sqrt(n); i++)
			{
				if(n%i == 0)
				{
					sum += i;
					if (n / i != n)
					{
						sum += n / i;
					}
				}
			}
			if(sum == n)
			{
				return 1;

			}
			else
			{
				return 0;
			}
		}
	}
}

