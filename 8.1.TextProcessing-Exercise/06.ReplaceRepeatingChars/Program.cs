using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder newText = new StringBuilder();
            newText.Append(text[0]);
            for (int i = 1; i < text.Length-1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    continue;
                }

                newText.Append(text[i+1]);
            }

            Console.WriteLine(newText.ToString());
        }
    }
}
