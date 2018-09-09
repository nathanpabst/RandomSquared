using System;
using System.Collections.Generic;

namespace RandomSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rando = new Random();
            List<int> nums = new List<int>();
            List<int> nums2 = new List<int>();
            List<int> evenNums = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                var results = rando.Next(1, 51);
                nums.Add(results);
            }
            Console.WriteLine("here are some random numbers");

            foreach (int num in nums)
            {
                Console.WriteLine(num);
                nums2.Add(num * num);
            }

            Console.WriteLine("now we square the random numbers");

            foreach (int num in nums2)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();

        }

    }

}
