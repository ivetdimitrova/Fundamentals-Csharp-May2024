namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int evenSum = 0;
            int oodSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else
                {
                    oodSum += numbers[i];
                }
            }

            //int difference = evenSum - oodSum;

            Console.WriteLine(evenSum - oodSum);
        }
    }
}
