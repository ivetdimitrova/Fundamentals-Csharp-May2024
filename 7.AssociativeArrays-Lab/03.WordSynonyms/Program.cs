namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string,List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word) )
                    words.Add(word, new List<string>());
              
                words[word].Add(synonym);
            }

            foreach (var word in words)
            {
                Console.Write($"{word.Key} - {String.Join(", ",word.Value)}");
               // List<string> synonyms = word.Value;
               //foreach(var synonym in synonyms)
               // Console.Write(synonym + " ");

               Console.WriteLine();
            }
        }
    }
}
