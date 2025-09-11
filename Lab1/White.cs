namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
using System;

class White1
{
    static void Main()
    {
        Console.Write("d: ");
        if (double.TryParse(Console.ReadLine(), out double d))
        {
            Console.WriteLine(d > 0 ? "положительное число" : "не положительное число");
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}

            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
using System;

class White2
{
    static void Main()
    {
        Console.Write("n: ");
        string input = Console.ReadLine();
        if (long.TryParse(input, out long n))
        {
            bool num = (n % 2 == 0);
            Console.WriteLine($"{n} { (num ? "четное" : "нечетное") }.");
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}

            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
using System;

class White3
{
    static void Main()
    {
        Console.Write("a, ");
        var inputA = Console.ReadLine();
        Console.Write("b:");
        var inputB = Console.ReadLine();

        if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
        {
            if (a > b)
            {
                Console.WriteLine($" {a} > {b} ");
            }
            else if (a < b)
            {
                Console.WriteLine($" {b} > {a} ");
            }
            else
            {
                Console.WriteLine("два числа равны");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}

            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
using System;

class White4
{
    static void Main()
    {
        Console.Write("d, ");
        string inputD = Console.ReadLine();
        Console.Write("f: ");
        string inputF = Console.ReadLine();

        if (double.TryParse(inputD, out double d) && double.TryParse(inputF, out double f))
        {
            double result = (Math.Abs(d) <= Math.Abs(f)) ? d : f;
            Console.WriteLine($"число с меньшим абсолютным значением:: {result}");
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
using System;

class White5
{
    static void Main()
    {
        Console.Write("x: ");
        string input = Console.ReadLine();
        if (double.TryParse(input, out double x))
        {
            double y = Math.Abs(x) > 1 ? 1.0 : x;
            Console.WriteLine($"y({x}) = {y}");
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
using System;

class White6
{
    static void Main()
    {
        Console.Write("x, ");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Неверный ввод");
            return;
        }

        Console.Write("y, ");
        if (!double.TryParse(Console.ReadLine(), out double y))
        {
            Console.WriteLine("Неверный ввод");
            return;
        }

        Console.Write("r: ");
        if (!double.TryParse(Console.ReadLine(), out double r))
        {
            Console.WriteLine("Неверный ввод");
            return;
        }

        double diff = x * x + y * y - r * r;

        const double EPS = 1e-6;

        if (Math.Abs(diff) <= EPS)
        {
            Console.WriteLine("Точка с координатами x, y лежит на окружности радиуса r");
        }
        else
        {
            Console.WriteLine("Точка с координатами x, y не лежит на окружности радиуса r.");
        }
    }
}
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;

            // code here
using System;

class White7
{
    static void Main(string[] args)
    {
        Console.Write("n: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int n))
        {
            Console.WriteLine("Неверный ввод");
            return;
        }

        bool answer = false;

        long s = (long)n * n;

        if (s - n > 2L * n)
        {
            answer = false;
        }
        else
        {
            if (n % 2 == 0)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
        }

        Console.WriteLine(answer ? "true" : "false");
    }
}
            // end

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
using System;

class White8 
{
    static void Main() 
    {
        double L = double.Parse(Console.ReadLine()); 
        int T = int.Parse(Console.ReadLine());       
        int M = int.Parse(Console.ReadLine());       
        bool Dock = (L <= 30.0) && ((T + M) >= 5) && (M % 2 == 0);
        Console.WriteLine(Dock ? "true" : "false");
    }
}
            // end

            return answer;
        }
    }
}


