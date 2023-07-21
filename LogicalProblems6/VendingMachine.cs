using System;
namespace LogicalProblems6
{
	public class VendingMachine
	{
		public List<int> notes = new List<int>();
		public int totalNotes;
        public List<int> money = new List<int>();

        public VendingMachine()
		{
			notes = new List<int>();
			money = new List<int>(8) { 1, 2, 5, 10,50,100,500,1000};
            totalNotes = 0;
		}
		public void GetChange(int sum, int n)
		{
			if(sum == 0 || n==0)
			{
				return;
			}

			else
			{

                this.totalNotes += sum / money[n - 1];
                if ((sum / money[n - 1]) != 0)
                {
					for (int i = 1; i <= sum / money[n - 1]; i++)

					{
						notes.Add(money[n - 1]);
					}
                }
                int newSum = (sum - (sum / money[n - 1]) * money[n - 1]);
                GetChange(newSum, n - 1);
				return;

            }

        }
	}
}

