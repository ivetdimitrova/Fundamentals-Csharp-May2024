using System.Diagnostics.CodeAnalysis;

namespace _11.Mathoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(number1,operation,number2));

        }

        static int Calculate(int number, char operation, int number2)
        {
            int sum = 0;
            switch (operation)
            {
                case '*':
                    sum = number * number2;
                    break;
                case '/':
                    sum = number / number2;
                    break;
                case '-':
                    sum = Math.Abs(number - number2);
                    break;
                case '+':
                    sum = number + number2;
                    break;
            }

            return sum;
        }
    }
}
