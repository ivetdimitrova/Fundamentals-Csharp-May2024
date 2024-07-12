namespace _01.AdvertisementMessage
{
    class Advertisement
    {
         public string[] Phrases = new[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product."
        };

        public string[] Events = new[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };
        public string[] Authors = new[]
        {
            "Diana", "Petya",
            "Stella", "Elena",
            "Katya", "Iva",
            "Annie", "Eva"
        };
        public string[] Cities = new[]
        {
            "Burgas", "Sofia",
            "Plovdiv", "Varna",
            "Ruse"
        };

        
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Advertisement advertisement = new Advertisement();
            int count = int.Parse(Console.ReadLine());

            Random random = new Random();

            
            for (int i = 1; i <= count; i++)
            {
                PrintMessage(advertisement,random);
            }
        }

        public static void PrintMessage(Advertisement advertisement, Random random )
        {
            
            int index = random.Next(0,advertisement.Phrases.Length);
            string phrase = advertisement.Phrases[index];

            index = random.Next(0, advertisement.Events.Length);
            string @event = advertisement.Events[index];

            index = random.Next(0, advertisement.Authors.Length);
            string author = advertisement.Authors[index];

             index = random.Next(0, advertisement.Cities.Length);
            string city = advertisement.Cities[index];

            Console.WriteLine($"{phrase} {@event} {author} – {city}.");
        }
    }
}
