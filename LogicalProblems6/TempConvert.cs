using System;
namespace LogicalProblems6
{
	public class TempConvert
	{
		public double ConvertToCelsius(double tempInF)
		{
			double degInCelsius = (tempInF - 32.0) * (5.0 / 9);
			return degInCelsius;
		}
        public double ConvertToFahrenheit(double tempInC)
        {
            
            double degInF = (tempInC * (9.0 / 5)) + 32;
            return degInF;
        }
    }
}

