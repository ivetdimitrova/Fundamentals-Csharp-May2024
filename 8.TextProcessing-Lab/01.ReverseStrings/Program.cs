namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> words = new Dictionary<string, string>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string reversedWord = "";
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedWord += input[i];
                }

                words.Add(input,reversedWord);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} = {word.Value}");
            }
        }
    }
}
