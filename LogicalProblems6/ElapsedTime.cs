using System;
using System.Diagnostics;

namespace LogicalProblems6
{
	public class ElapsedTime
	{
		public void GetElapsedTime()
		{
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Enter any key to stop the watch");
            Console.ReadKey();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("RunTime " + ts);
        }
	}
}

