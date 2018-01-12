using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1taskone
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine(); // string input
            string [] arr = x.Split(); // to convert input to array of strings by ignoring SpaceBar
            int[] nums = new int[arr.Length]; // array of integers
            for (int i=0; i<arr.Length; i++)
            {
                nums[i] = int.Parse(arr[i]); // convert strings to integers
            }
            foreach (int q in nums) // searching primes
            {
                if (q==2 || q==3) // because 2 and 3 are exceptions
                {
                    Console.WriteLine(q);
                    continue;
                }
                for (int i=2; i<=q/2; i++) // don't know why, but code doesn't want to work when I use Math.Sqrt
                {
                    if (q%i==0)
                    {
                        break; // if there are more divisors, then check the next number
                    }
                    if (q%i!=0 && (i==q/2))
                    {
                        Console.WriteLine(q); // to output our prime numbers
                    }
                }
            }
            Console.ReadKey(); // to view the result of the program
        }
    }
}
