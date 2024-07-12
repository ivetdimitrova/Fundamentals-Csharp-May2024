
namespace _03.Articles2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string[] information = Console.ReadLine().Split(",").ToArray();
                TakeInformation(articles, information);

            }

            foreach (Article article in articles)
            {
                Console.WriteLine($"{article.Title} -{article.Content}:{article.Author}");
            }
        }

        private static void TakeInformation(List<Article> articles, string[] information)
        {
            Article article = new Article();

            article.Title = information[0];
            article.Content = information[1];
            article.Author = information[2];

            articles.Add(article);
        }
    }
}
