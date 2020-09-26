using System;

namespace iteration_VIvek
{
    class Program
    {
        static int Triangular(int a)
        {
            return ((a)*(a+1)/2);
        }
        static void Timestable(int i, int m)
        {
            
            int j = 0;
            for (j = 1; j < m + 1; j++)
            {

                Console.WriteLine(j + " x " + i + " = " + i * j);

                


            }
        

        }
        static void AskN(int n)
        {
            int i = 1;
            do
            {
                Console.Write("Enter number:");
                Console.ReadLine();
                i++;



            } while (i <= n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Triangular(4));
            Timestable(5, 6);
            AskN(3);
            Console.WriteLine(BioQuestion1("020110?311"));
        }
        static double BioQuestion1(string isbn)
        {

            
            int i = 0;
            double total=0;
            
            for (i=0;i<10; i++)
            {
                if (isbn[i] == 'X')
                {
                    total += 10 * (10 - i);
                }
                

                if (isbn[i] != '?')
                {
                    double number=Char.GetNumericValue(isbn[i]);
                    total +=number * (10 - i);
                    //Console.WriteLine(total);
                }
            }
            int index1 = isbn.IndexOf('?');
            int r = 0;
            double y = total;
            while(total%11!=0)
            {
                
                total += (10 - index1);
            }
            return -1*(y-total)/(10-index1);
        }
    }
}
