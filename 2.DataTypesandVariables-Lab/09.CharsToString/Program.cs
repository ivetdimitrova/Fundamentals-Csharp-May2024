namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                text += symbol;
            }

            Console.WriteLine(text);

        }
    }
}
