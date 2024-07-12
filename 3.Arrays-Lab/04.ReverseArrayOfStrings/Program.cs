namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letter = Console.ReadLine().Split(" ").ToArray();

            for (int i = 0; i < letter.Length; i++)
            {
                Console.Write(letter[letter.Length - 1 - i] + " ");
            }
        }
    }
}
