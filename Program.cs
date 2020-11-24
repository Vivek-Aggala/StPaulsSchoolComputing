using System;
using System.Collections.Generic;
namespace CircularQueue
{
    class CircularQueue
    {
        
        private int[] queue;
        private int head;
        private int tail;
        private int max;
        private int count;

        public CircularQueue(int size)
        {
            max = size;
            count = 0;
            queue = new int[size];
            head = 0;
            tail = -1;
            
        }

        public void enqueue(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                tail = (tail + 1) % max;
                queue[tail] = item;

                count++;
            }
        }

        public void dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("deleted element is: " + queue[head]);

                head = (head + 1) % max;

                count--;
            }
        }

        public void printQueue()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (i = head; j < count;)
                {
                    Console.WriteLine(queue[i]);

                    i = (i + 1) % max;
                    j++;

                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            CircularQueue newy= new CircularQueue(5);

            newy.enqueue(10);
            newy.enqueue(20);
            newy.enqueue(30);
            newy.enqueue(40);
            newy.enqueue(50);
            Console.WriteLine("Items are : ");
            newy.printQueue();
            newy.dequeue();
            newy.dequeue();
            newy.enqueue(60);
            newy.enqueue(70);
            Console.WriteLine("Items are : ");
            newy.printQueue();

        }
    }
}
