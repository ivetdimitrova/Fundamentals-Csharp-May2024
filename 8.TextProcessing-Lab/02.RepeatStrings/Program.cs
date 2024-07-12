using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            StringBuilder concatenatedString = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    concatenatedString.Append(word);
                }
            }

            Console.WriteLine(concatenatedString);
        }
    }
}
