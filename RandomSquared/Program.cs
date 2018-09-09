using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine("now we remove the odd numbers");

            //Where() returns a new object linked to nums2 and filters the even numbers
            //ToList() creates a new list object with the collection and returns the collection
            var removeOdds = nums2.Where(x => x % 2 == 0).ToList();

            foreach (int num in removeOdds)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();

        }

    }

}
