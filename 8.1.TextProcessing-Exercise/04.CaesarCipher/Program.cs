using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();

           StringBuilder newText = new StringBuilder();

           foreach (char character in text)
           {
               char newCharacter = (char)((int)character + 3);

               newText.Append(newCharacter);
           }

           Console.WriteLine(newText.ToString());
        }
    }
}
