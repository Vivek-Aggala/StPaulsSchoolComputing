using System;

namespace functions_Vivek
{
    class Program
    {
        
        static int SumTwo(int a, int b)
        {
            return(a + b);
        }
        static double SumTwo(double a, double b)
        {
            return (a + b);

        }
        static int Spacey(string e)
        {
            var strArray = e.Split(new char[] { ' ' });
            int countSpace = strArray.Length - 1;
            return countSpace;

        }
        public static string ToBinary(int n)
        {
            if (n < 2) return n.ToString();

            var divisor = n / 2;
            var remainder = n % 2;

            return ToBinary(divisor) + remainder;

        }
        static int AddDigits(int n)
        {
             int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
            Console.WriteLine(ToBinary(67));
            Console.WriteLine(Spacey("Luke, I am your father"));
            Console.WriteLine(AddDigits(4765));
        }


    }
}
