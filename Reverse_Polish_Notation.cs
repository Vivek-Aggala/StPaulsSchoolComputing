using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;


namespace reverse_polish_lol
{
    class Program
    {
        static void Main(string[] args)
        {
            /* code works by inputing each element of stack on different lines-Vivek*/
            Console.WriteLine("Hello World!");
            var stack = new Stack<T>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "+")
                {
                    stack.Push(stack.Pop() + stack.Pop());
                    Console.WriteLine(stack.Peek());
                }
                else if (input == "*")
                {
                    stack.Push(stack.Pop() * stack.Pop());
                    Console.WriteLine(stack.Peek());
                }
                else
                {
                    double result;
                    if (Double.TryParse(input, out result))
                    {
                        stack.Push(result);
                    }
                }
            }
        }
        

    }
}
