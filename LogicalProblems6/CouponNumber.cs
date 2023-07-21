using System;
namespace LogicalProblems6
{
    public class CouponNumber
    {
        public int RndNumberGenerated(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int cntRnd = 0;

            while (n != 0)
            {
                Random rnd = new Random();
                int rndNumber = rnd.Next(0, 50);
                Console.WriteLine($"{rndNumber}");
                if (dict.ContainsKey(rndNumber))
                {
                    cntRnd++;
                }
                else
                {
                    dict[rndNumber] = 1;
                    cntRnd++;
                    n--;

                }

            }

            return cntRnd;

        }
    }
}
