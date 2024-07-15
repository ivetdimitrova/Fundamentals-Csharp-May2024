namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ")
                .ToArray();

            foreach (var username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                bool isValidName =
                    username.All(symbol => char.IsLetterOrDigit(symbol) 
                                           || symbol == '-' 
                                           || symbol == '_');

                if (isValidName)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
