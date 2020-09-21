using System;
using System.Collections;

namespace selection_Vivek
{
    class Program
    {
        static void Main(string[] args)
        {
            //check if even or odd
            int num1;
            Console.Write("Enter Number to see whether odd or even");
            num1 = Convert.ToInt32(Console.ReadLine());
            switch (num1 % 2)
            {
                case 1:
                    Console.WriteLine("odd");
                    break;
                case 0:
                    Console.WriteLine("even");
                    break;

            }


            //cartesian co-ordinates
            int co1, co2;

            

            Console.Write("Input the value for X coordinate :");
            co1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            co2 = Convert.ToInt32(Console.ReadLine());
            

            if (co1 > 0 && co2 > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the First quandrant.\n\n", co1, co2);
            else if (co1 < 0 && co2 > 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Second quandrant.\n\n", co1, co2);
            else if (co1 < 0 && co2 < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Third quandrant.\n\n", co1, co2);
            else if (co1 > 0 && co2 < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.\n\n", co1, co2);
            else if (co1 == 0 && co2 == 0)
                Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", co1, co2);

            //BIO 2001 Q1
            int num_friends,num_words,i;
            Console.Write("Number of Friends");
            num_friends = Convert.ToInt32(Console.ReadLine());
            Console.Write("Words in rhyme");
            num_words = Convert.ToInt32(Console.ReadLine());
            ArrayList friends = new ArrayList();
            for (i = 0; i <=num_friends-1; i++)
            {
                friends.Add(i + 1);
            }

            //Console.WriteLine((num_words%num_friends)+1);
            int j,p;
            Console.Write("\nElements in array are: ");
            for (j = 0; j < friends.Count; j++)
            {
                Console.Write("{0}  ", friends[j]);
            }
            Console.Write("\n");
            
            for (int m = 0; m < num_friends - 1; m++)
            {

                p = ((num_words % friends.Count));
                if (p == 0)
                    p = friends.Count - 1;
                
                Console.WriteLine(p);
                friends.RemoveAt(p-1);
                /*for (int q = 0; q < friends.Count; q++)
                {
                    Console.Write("{0}  ", friends[q]);
                }*/


            }

            Console.Write("\nElements in new array are: ");
            for (int y = 0; y < friends.Count; y++)
            {
                Console.Write("{0}  ", friends[y]);
            }






        }
    }
}
