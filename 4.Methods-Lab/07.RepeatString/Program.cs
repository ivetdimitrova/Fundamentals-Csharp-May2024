namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            string result = RepeatString(symbols, times);

            Console.WriteLine(result);
        }

        static string RepeatString(string str, int times)
        {
            string result = " ";
            for (int i = 0; i < times; i++)
            {
                result += str;

            }
            return result;
        }
    }
}
