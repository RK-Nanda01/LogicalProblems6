﻿using System;
using System.Security.Principal;

namespace LogicalProblems6
{
	public class UtilClass
	{
		public void DayOfWeek(int d,int m,int y)
		{
			int y0 = y - ((14 - m) / 12);
			int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
			int m0 = m + 12 * ((14 - m) / 12) - 2;
			int d0 = (d + x + ((31 * m0) / 12)) % 7;

			switch(d0)
			{
				case 0:
					{
						Console.WriteLine("Sunday");
						break;
					}
                case 1:
                    {
                        Console.WriteLine("Monday");
						break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
            }
		}
        public double MonthlyPayment(int principalAmount,int year, double rate)
        {
          
            double monthlyInterestRate = rate / (12 * 100); // Convert interest rate to monthly rate
            int totalMonths = year * 12;
            double monthlyPayment = (principalAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -totalMonths));
            return monthlyPayment;
        }
	}


}

