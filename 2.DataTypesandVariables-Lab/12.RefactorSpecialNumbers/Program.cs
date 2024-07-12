namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool isSpecialNumber = false;
            for (int i = 1; i <= count; i++)
            {
                number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
                sum = 0;
               
            }
        }
    }
}
