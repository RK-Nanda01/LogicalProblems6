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

		public static double GetSquareRoot(int number)
		{
            double epsilon = 1e-15; // The precision of the result
            double t = number; 
            while (Math.Abs(t - number / t) > epsilon * t)
            {
                t = (number / t + t) / 2.0;
                
            }
            return t;
        }

		public static char[] ToBinary(int num)
		{
            const int bits = 32;
            char[] binaryForm = new char[32];
            for (int i = bits - 1; i >= 0; i--)
            {
                // Calculate the bit value at the current position
                int bit = (num & (1 << i)) == 0 ? 0 : 1;

                // Convert the integer value of 'bit' to a character representation ('0' or '1')
                binaryForm[bits - i - 1] = (char)(bit + '0');
               
            }

            return binaryForm;

        }
    }
}

