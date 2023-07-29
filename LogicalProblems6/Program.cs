using System;

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
            Console.WriteLine("6. Print Elapsed Time");
            Console.WriteLine("7. Vending Machine");
            Console.WriteLine("8. Day Of the Week");
            Console.WriteLine("9. Convert Temperature-> F to C");
            Console.WriteLine("10. Convert Temperature-> C to F");
            Console.WriteLine("11. Calculate Monthly Payment");
            Console.WriteLine("12. Calculate Sqrt of a positive Number");
            Console.WriteLine("13. Get Binary of a Number");
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
                case 6:
                    {
                        ElapsedTime et = new ElapsedTime();
                        et.GetElapsedTime();
                        break;
                    }
                case 7:
                    {
                        VendingMachine vm = new VendingMachine();
                        int sum;
                        Console.WriteLine($"Enter the amount");
                        sum = Convert.ToInt32(Console.ReadLine());
                        vm.GetChange(sum,8);
                        Console.WriteLine($"Total Notes required {vm.totalNotes}");
                        Console.WriteLine($"Notes given by the vending machine are :-");
                        foreach(int v in vm.notes)
                        {
                            Console.Write($"{v} ");
                        }
                        Console.Write("\n");

                        break;
                    }
                case 8:
                    {
                        UtilClass uc = new UtilClass();
                        int d,m,y;
                        Console.WriteLine($"Enter date");
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter Month");
                        m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter Year");
                        y = Convert.ToInt32(Console.ReadLine());
                        uc.DayOfWeek(d, m, y);
                        break;
                    }
                case 9:
                    {
                        TempConvert t = new TempConvert();
                        double tempInF;
                        double tempInC;
                        Console.WriteLine($"Enter Temp in Fahreheit");
                        tempInF = Convert.ToDouble(Console.ReadLine());
                        tempInC = t.ConvertToCelsius(tempInF);
                        Console.WriteLine($"Temperature in Celsius is {tempInC}");
                       
                        break;
                    }
                case 10:
                    {
                        TempConvert t = new TempConvert();
                        double tempInF;
                        double tempInC;
                        Console.WriteLine($"Enter Temp in Celsius");
                        tempInC = Convert.ToDouble(Console.ReadLine());
                        tempInF = t.ConvertToFahrenheit(tempInC);
                        Console.WriteLine($"Temperature in Fahrenheit is {tempInF}");
                        break;
                    }
                case 11:
                    {
                        UtilClass pay = new UtilClass();
                        int amount, year;
                        double rate;
                        Console.WriteLine($"Enter Value of Amount");
                        amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter Year");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter Rate of Interest");
                        rate = Convert.ToDouble(Console.ReadLine());
                        double monthlyPayment = pay.MonthlyPayment(amount, year, rate);
                        Console.WriteLine($"Monthly Payment to be made is {monthlyPayment}");
                        break;
                    }
                case 12:
                    {
                        int n;
                        Console.WriteLine("Enter a Non-Negative Number");
                        n = Convert.ToInt32(Console.ReadLine());
                        if(n < 0)
                        {
                            Console.WriteLine("Enter a Non-Negative Number");
                        }
                        else
                        {
                            double sqrt = Number.GetSquareRoot(n);
                            Console.WriteLine($"Square Root of {n} is {sqrt}");
                        }    
                        break;
                    }
                case 13:
                    {
                        int n;
                        Console.WriteLine("Enter Number to convert to Binary");
                        n = Convert.ToInt32(Console.ReadLine());
                        Number.ToBinary(n);
                        break;
                    }

            }
        }
    }
}

