namespace _09.SumofOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOddNumbers = int.Parse(Console.ReadLine());

            int sum = 0;
            int oddNumber = 1;
            for(int i = 0; i < countOfOddNumbers; i++)
            {
                sum += oddNumber;
                Console.WriteLine(oddNumber);
                oddNumber += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
