namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int end = int.Parse(Console.ReadLine());

            for (int i = 1; i <= end; i++)
            {
                int number = i;
                int num = i;
            int sum = 0;
                while(num > 0) 
                {
                    int digits = num % 10;
                    num  /= 10;
                    sum += digits;
                }
                switch(sum)
                {
                    case 5:
                    case 7:
                    case 11:
                        Console.WriteLine($"{number} -> True");
                        break;
                    default:
                        Console.WriteLine($"{number} -> False");
                        break;

                }

            }
        }
    }
}
