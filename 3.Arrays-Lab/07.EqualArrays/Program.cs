using System;
using System.Runtime.InteropServices;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sum = 0;
            int difference = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (difference == 0 && array[i] != array2[i])
                {
                    difference++;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                }
                else
                {
                    sum += array[i];
                }

            }
            if (difference == 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
