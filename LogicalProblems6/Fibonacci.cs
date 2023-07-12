using System;
namespace LogicalProblems6
{
	public class Fibonacci
	{
		public int Fib(int n)
		{
			
			if(n<=1) {
				return n;
			}
			else {
					
				return Fib(n - 1) + Fib(n - 2);
			}
		}
	}
}

