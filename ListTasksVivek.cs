using System;
using System.Collections.Generic;

namespace lists_Vivek
{
    class Program
    {
        static int Sum(List<int> listA)
        {
            int total = 0;
            foreach (int i in listA)
            {
                total += i;
            }
            return total;
        }
        static int MaxOfList(List<int> x)
        {
            int max = x[0];
            for (int i = 1; i < x.Count; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
            }
            return max;
        }

        static int MinOfList(List<int> x)
        {
            int min = x[0];
            for (int i = 1; i < x.Count; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                }
            }
            return min;
        }

        static bool Samestuff(List<int> a, List<int> b)
        {
            bool value = true;

            foreach (int i in a)
            {
                if (!b.Contains(i))
                {
                    return false;
                }
            }
            foreach (int i in b)
            {
                if (!a.Contains(i))
                {
                    return false;
                }
            }

            return value;
        }




            static List<int> Negatives(List<int> listC)
        {
            
            List<int> values = new List<int>();
            foreach(int x in listC)
            {
                if (x < 0)
                    values.Add(x);
            }
            return values;
            
        }

        static int binarySearch(List<int> listy, int x)
        {
            //x is item ur looking for
            int l = 0, r = listy.Count - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid 
                if (listy[m] == x)
                    return m;

                // If x greater, ignore left half 
                if (listy[m] < x)
                    l = m + 1;

                // If x is smaller, ignore right half 
                else
                    r = m - 1;
            }

             
            return -1;
        }

        static void InsertionSort(List<int> listy)
        {
            for (int i = 0; i < listy.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (listy[j - 1] > listy[j])
                    {
                        int temp = listy[j - 1];
                        listy[j - 1] = listy[j];
                        listy[j] = temp;
                    }
                }
                
            }
            foreach (int i in listy)
            {
                Console.Write(i.ToString() + "  ");
            }
        }



            static void Main(string[] args)
        {
            List<int> SomeList = new List<int> { 1, 2, 5, 9, 11, 13, 17, 19, 21, 27 };
            Console.WriteLine(binarySearch(SomeList,5));
            List<int> numbers = new List<int> { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            InsertionSort(numbers);
            Console.WriteLine("");

        }
    }
}
