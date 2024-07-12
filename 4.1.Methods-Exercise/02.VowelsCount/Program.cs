namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string sentence = Console.ReadLine();

            int vowelsCount = GetVowelsCount(sentence);

            Console.WriteLine(vowelsCount);
        }

        private static int GetVowelsCount(string sentence)
        {
            int count = 0;

            sentence = sentence.ToLower();
            foreach (char symbol in sentence)
            {
                switch (symbol)
                {
                    case 'e':
                    case 'o':
                    case 'a':
                    case 'i':
                    case 'u':
                    count++;
                    break;
                }
            }
            return count;
        }

            
        
    }
}
