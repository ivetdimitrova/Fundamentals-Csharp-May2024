using System.Numerics;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if(secondNumber <= 10)
            {
                for(int i = secondNumber; i <= 10;i++)
                {
                    Console.WriteLine($"{firstNumber} X {i} = {firstNumber * i}");
                }
            }
            else
            {
                Console.WriteLine($"{firstNumber} X {secondNumber} = {firstNumber * secondNumber}");
            }
        }
    }
}
