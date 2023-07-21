using System;
namespace LogicalProblems6
{
	public class Fibonacci
	{
		public void Fib(int n)
		{
			int firstNumber = 0, secondNumber=1, sum=1;

			Console.Write($"{firstNumber}, {secondNumber}");
			for(int i = 2; i<=n;i++)
			{
                Console.Write($", {sum}");
                firstNumber = secondNumber;
                secondNumber = sum;
				sum = firstNumber + secondNumber;
				
			}

			Console.Write("\n");
			
		}
	}
}

