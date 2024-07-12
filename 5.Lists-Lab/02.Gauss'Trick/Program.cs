
using System.Threading.Channels;

namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            IsTheCountEven(numbers);
            IsTheCountOdd(numbers);
        }
        static void IsTheCountOdd(List<int> numbers)
        {
            
            if (numbers.Count % 2 != 0) 
            {
                List<int> newList = new List<int>();

                int sum = numbers[numbers.Count/2];
                for (int i = 0; i < numbers.Count ; i++)
                {

                    newList.Add(sum);
                    sum = numbers[i] + numbers[numbers.Count - 1 - i];
                    if (i >= numbers.Count / 2)
                    {
                        break;
                    }

                }
                newList.Reverse();
                Console.WriteLine(String.Join(" ", newList));
            }
        }

        static void IsTheCountEven(List<int> numbers)
        {
           
            if (numbers.Count % 2 == 0)
            {
                List<int> newList = new List<int>();
                int sum = 0;
                for (int i = 0; i < numbers.Count/2; i++)
                {
                    sum = numbers[i] + numbers[numbers.Count - 1 - i];
                    newList.Add(sum);
                }

                Console.WriteLine(String.Join(" ",newList));
            }

        }
    }
}
