using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

    class Class1
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 100, 20, 10, 50, 60, 30, 40, 70, 80, 90 };
            int[] array2 = new int[] { 5, 97, 50, 43, 37, 30, 80, 69, 20, 87 };

        Console.WriteLine("\n---union----");
            var query1 = (from i in array1 select i).Union(from j in array2 select j);

            foreach (int i in query1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n---------intersect--------------");

            var query2 = (from i in array1 select i).Intersect(from j in array2 select j);

            foreach (int i in query2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n---------except--------------");

            var query3 = (from i in array1 select i).Except(from j in array2 select j);

            foreach (int i in query3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n--------concat---------------");

            var query4 = (from i in array1 select i).Concat(from j in array2 select j);

            foreach (int i in query4)
            {
                Console.WriteLine(i);
            }

            //Aggregate Functions

            Console.WriteLine("\n-----Aggregate Functions-----");

            Console.WriteLine("\n----Sum-----");

            int sum1 = (from i in array1 select i).Sum();
            int sum2 = (from i in array2 select i).Sum();

            Console.WriteLine((sum1 + sum2));

            Console.WriteLine("\n-----Max-----");

            int max1 = (from i in array1 select i).Max();
            int max2 = (from i in array2 select i).Max();

            Console.WriteLine((max1, max2));

            Console.WriteLine("\n-----Min-----");

            int min1 = (from i in array1 select i).Min();
            int min2 = (from i in array2 select i).Min();

            Console.WriteLine((min1, min2));

        Console.WriteLine("\n----average---");
            double avg1 = (from i in array1 select i).Average();
            double avg2 = (from i in array2 select i).Average();

            Console.WriteLine((avg1, avg2));

            Console.WriteLine("\n-----Count------");

            int count1 = (from i in array1 select i).Count();
            int count2 = (from i in array2 select i).Count();

            Console.WriteLine((count1, count2));

        }
    }

