namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            int allnumber = number;
            int factorialSum = 0;
           while (number > 0)
            {
                int endNum = number % 10;
                number /= 10;
            int factorialSum1 = 1;
                for(int i = 1; i <= endNum; i++)
                {
                    factorialSum1 *= i;
                }
                factorialSum += factorialSum1;
            }
            string isStrongNumber = factorialSum == allnumber ? "yes" : "no";
            Console.WriteLine(isStrongNumber);
           
        }
    }
}
