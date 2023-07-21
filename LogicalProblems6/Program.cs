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
            Console.WriteLine("2. Check for Perfect Number");
            Console.WriteLine("3. Check for Prime Number");
            Console.WriteLine("4. Reverse a Number");
            Console.WriteLine("5. Random Numbers need to generate N unique Coupons");
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
                        Console.WriteLine($"The Fibonacci Sequence for {n} terms is:->");
                        f.Fib(n);
                        break;
                    }

                case 2:
                    {
                        int n;
                        int res;
                        PerfectNumber p = new PerfectNumber();
                        Console.WriteLine("Enter Number to Check for Perfect Number");
                        n = Convert.ToInt32(Console.ReadLine());
                        res = p.IsPerfect(n);
                        if(res == 1)
                        {
                            Console.WriteLine($"The number {n} is Perfect");
                        }
                        else
                        {
                            Console.WriteLine($"The number {n} is Not Perfect");
                        }
                        break;
                    }
                case 3:
                    {
                        int n;
                        int res;
                        PrimeNumber pr = new PrimeNumber();
                        Console.WriteLine("Enter Number to Check for Prime Number");
                        n = Convert.ToInt32(Console.ReadLine());
                        res = pr.IsPrime(n);
                        if (res == 1)
                        {
                            Console.WriteLine($"The number {n} is Prime");
                        }
                        else if(res == 0)
                        {
                            Console.WriteLine($"The number {n} is Not Prime");
                        }
                        else
                        {
                            Console.WriteLine($"The number {n} is Neither Prime nor Composite");
                        }
                        break;
                    }
                case 4:
                    {
                        int n;
                        int res;
                        Number num = new Number();
                        Console.WriteLine("Enter Number to Reverse");
                        n = Convert.ToInt32(Console.ReadLine());
                        res = num.ReverseNumber(n);
                        Console.WriteLine($"Before Reversing:-> {n}");
                        Console.WriteLine($"After Reversing:-> {res}");
                        break;
                    }
                case 5:
                    {
                        int n;
                        int res;
                        CouponNumber coupon = new CouponNumber();
                        Console.WriteLine("Enter Number of distinct coupon numbers");
                        n = Convert.ToInt32(Console.ReadLine());
                        res = coupon.RndNumberGenerated(n);
                        Console.WriteLine($"Total Random Number generated is {res}");
                        break;
                    }

            }
        }
    }
}

