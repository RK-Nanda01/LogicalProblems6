using System;
namespace LogicalProblems6
{
	public class Binary
	{
		public int SwapNibbles(int n)
		{

            int lowerNibble = n & 00001111; // Get LSB 4 bits
            int upperNibble = n & 11110000; // Gets MSB 4 bits

            int swappedNumber = (lowerNibble << 4) | (upperNibble >> 4);

            return swappedNumber;
        }

        public bool IsPowerOf2(int n)
        {
             // Powers of 2 have only 1 bit set// 1000 -> 8
             // n-1 is say 7, 0111, leaving MSB evry bit will be set.
             // hence on & it results in 0-> Power of 2 else not a power of 2//
            if((n & (n-1)) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


	}
}

