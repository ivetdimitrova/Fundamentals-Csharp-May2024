using System.Globalization;

namespace _02.Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();

            string[]article1 = Console.ReadLine().Split(",").ToArray();
            article.Title = article1[0];
            article.Content = article1[1];
            article.Author = article1[2];

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split(":").ToArray();

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }

            Console.WriteLine($"{article.Title} -{article.Content}:{article.Author}");
        }
    }
}
