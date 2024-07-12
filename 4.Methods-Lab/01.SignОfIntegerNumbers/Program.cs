using System.Threading.Channels;

namespace _01.SignОfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            IsPositive(number);
            IsNegative(number);
            IsTheNumberZero(number);
            void IsPositive(int number)
            {
                if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
            }

            void IsNegative(int number)
            {
                if (number < 0)
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
            }

            void IsTheNumberZero(int number)
            {
                if (number == 0)
                {
                    Console.WriteLine($"The number {number} is zero.");
                }

            }
        }
    }
}
