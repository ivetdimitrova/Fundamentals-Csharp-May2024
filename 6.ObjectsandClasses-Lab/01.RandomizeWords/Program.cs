namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> separated = input.Split().ToList();
            List<string> randomizeWords = new List<string>();
            Random random = new Random();
            for (int i = 0; i < separated.Count; i+= 0)
            {
                int randomIndex = random.Next(0, separated.Count);
                string value = separated[randomIndex];
                randomizeWords.Add(value);
                separated.RemoveAt(randomIndex);
                
            }

            foreach (string element in randomizeWords)
            {
                Console.WriteLine(element);
            }
        }
    }
}
