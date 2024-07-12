using System.Collections.Generic;
using System.Globalization;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List< int> bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int bombNumber = bomb[0];
                int power = bomb[1];
                while (numbers.Contains(bombNumber))
                {
                    int index = numbers.IndexOf(bombNumber);

                    int leftIndex = Math.Max(0, index - power);
                    int rightIndex = Math.Min(numbers.Count - 1, index + power);

                    int range = rightIndex - leftIndex + 1;
                    numbers.RemoveRange(leftIndex, range);
                }
            }

            int sum = 0;
            foreach (int element in numbers)
            {
                sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}
