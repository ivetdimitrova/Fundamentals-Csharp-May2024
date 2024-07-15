
namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            string text1 = input[0];
            string text2 = input[1];

            int totalSum = 0;
            if (text1.Length > text2.Length)
            {
                totalSum= CalculationOfTheAmount(text1,text2);
            }
            else if (text2.Length > text1.Length)
            {
                totalSum = CalculationOfTheAmount(text2, text1);
            }
            else if (text1.Length == text2.Length)
            {
                totalSum = CalculationOfTheAmount(text1, text2);
            }

            Console.WriteLine(totalSum);
        }

        private static int CalculationOfTheAmount(string text1, string text2)
        {
            int amount = 0;
            for (int i = 0; i < text1.Length; i++)
            {
                if (i < text2.Length)
                {
                    amount += (int)text1[i] * (int)text2[i];
                }
                else
                {
                    amount += (int)text1[i];
                }
            }

            return amount;
        }
    }
}
