namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d > 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            if (n % 2 == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }

            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) > Math.Abs(f))
            {
                answer = f;
            }
            else
            {
                answer = d;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 1;
            }
            else
            {
                answer = x;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10,-6) || Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -2))
            {
                answer = true;
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
            if (L <= 30 && M % 2 == 0 && M + T >= 5)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}




