﻿using System.Runtime.Serialization.Formatters;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
