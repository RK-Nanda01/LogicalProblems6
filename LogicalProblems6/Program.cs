namespace LogicalProblems6;
class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        int option;
        Console.WriteLine("Welcome to Logical Problem Assignment!");
        while (flag)
        {
            Console.WriteLine("MENU:->");
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("0. Exit");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    {
                        flag = false;
                        break;
                    }
                case 1:
                    {
                        int n;
                        Fibonacci f = new Fibonacci();
                        Console.WriteLine("Enter Number to get Fibonacci Sequence");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"The {n}th Fibonacci term is {f.Fib(n-1)}");
                        break;
                    }



            }
        }
    }
}

