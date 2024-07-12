namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string username = Console.ReadLine();

            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string password = new string(stringArray);

            int atempts = 4;
            while (true)
            {
                string tryPassword = Console.ReadLine();
                atempts--;
                if (atempts == 0)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    if (tryPassword == password)
                    {
                        Console.WriteLine($"User {username} logged in.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");

                    }
                }
            }
        }
    }
}
