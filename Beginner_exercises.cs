using System;
using System.Security.Cryptography;

namespace helloooo
{
    class helloooo
    {
        static void Main(string[] args)
        {
            // enter time and speed in m/s displayed
            Console.WriteLine("Enter time: ");
            double mins = Double.Parse(Console.ReadLine());
            double secs = Double.Parse(Console.ReadLine());
            double metres_per_second = 10000 / ((mins * 60) + secs);
            Console.WriteLine(metres_per_second+"m/s");
            double miles_per_hour = metres_per_second * 2.23694;
            Console.WriteLine(miles_per_hour + "mph");
            //miles per hour displayed
            Console.Write("Enter number: ");
            int numero = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 1; i < rows+1; i++)
            {
                Console.WriteLine(i + " x " + numero + " = " + i * numero);
            
                
            }
            //enter radius and recieve circumference
            Console.Write("enter radius:");
            double pi = Math.PI;
            double radius = Double.Parse(Console.ReadLine());
            Console.WriteLine("circumference: "+radius*pi*2 );

            //BIO 2002 lojban
            Console.Write("enter lojban number:");
            string lojban = Console.ReadLine();
            string[] numbers = { "no","pa","re","ci","vo","mu","xa","ze","bi","so" };
            int count = (lojban.Length)/2;
            int[] finalnum = new int[count];
            for (int j = 0; j < count; j++)
            {
                string p=lojban.Substring(j * 2, 2);
                //Console.WriteLine(p);
                int index = Array.IndexOf(numbers, p);
                //Console.WriteLine(index);
                finalnum[j] = index;


            }
            int finalScore = 0;
            //Console.WriteLine(string.Join(" ",finalnum));
            for (int z = 0; z < finalnum.Length; z++)
            {
                finalScore += finalnum[z] * Convert.ToInt32(Math.Pow(10, finalnum.Length - z - 1));
            }
            Console.WriteLine(finalScore);
        }


    }
}
