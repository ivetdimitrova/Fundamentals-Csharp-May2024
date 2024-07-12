namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Dictionary<char,int> charsCount = new Dictionary<char,int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                foreach(char ch in word)
                {
                    if (charsCount.ContainsKey(ch))
                    {
                        charsCount[ch]++;
                    }
                    else
                    {
                        charsCount[ch] = 1;
                    }
                }
            }

            foreach (var symbol in charsCount)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
