
using System.Globalization;

namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                    .Split()
                .Select(double.Parse)
                .ToList();

            bool hasAdjacentEqualNumbers = true;

            while (hasAdjacentEqualNumbers)
            {
                hasAdjacentEqualNumbers = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        hasAdjacentEqualNumbers = true;
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }

        

    
}


        
    
