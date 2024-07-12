namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while (number != 0)
            {
                int digit = Math.Abs(number % 10);
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                number /= 10;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int OddSum = 0;
            while (number != 0)
            {
                int digit = Math.Abs(number % 10);
                if (digit % 2 != 0)
                {
                    OddSum += digit;
                }
                number /= 10;
            }
            return OddSum;
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return evenSum * oddSum;
        }
        
        
    }
}
