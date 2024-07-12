


using System.Runtime.InteropServices;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> other = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                IsDigit(digits, symbol);
                IsLetter(letters, symbol);
                IsOther(other,symbol);
            }

            if (digits.Count > 0)
            {
                Print(digits);
            } 

            if (letters.Count > 0)
            {
                Print(letters);
            }

            if (other.Count > 0)
            {
                Print(other);
            }
        }

        private static void Print(List<char> list)
        {
            foreach (char symbol in list)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }

        private static void IsOther(List<char> other, char symbol)
        {
            int num = (int)symbol;

            if (num >= 33 && num <= 47 || num >= 58 && num <= 64 
                                       || num >= 91 && num <= 96
                                       || num >= 123 && num <= 126)
            {
                other.Add(symbol);
            }
        }

        private static void IsLetter(List<char> letters, char symbol)
        {
            int num = (int)symbol;

            if (num >= 65 && num <= 90 || num >= 97 && num <= 122)
            {
                letters.Add(symbol);
            }
            
        }

        private static void IsDigit(List<char> digits, char symbol)
        {
            int num = (int)symbol;

            if (num >= 48 && num <= 57)
            {
                digits.Add(symbol);
            }
        }
    }
}
