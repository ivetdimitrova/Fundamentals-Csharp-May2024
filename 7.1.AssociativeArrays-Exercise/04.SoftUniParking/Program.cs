

using System.Runtime.InteropServices;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> parking = new Dictionary<string,string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                switch (command[0])
                {
                    case "register":
                        Register(parking, command[1], command[2]);
                        break;
                    case "unregister":
                        Unregister(parking, command[1]);
                        break;
                }
            }

            Print(parking);
        }

        private static void Print(Dictionary<string, string> parking)
        {
            foreach (var user in parking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        private static void Unregister(Dictionary<string, string> parking, string username)
        {
            if (!parking.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                Console.WriteLine($"{username} unregistered successfully");
                parking.Remove(username);
            }
        }

        private static void Register(Dictionary<string, string> parking, string username, string licensePlateNumber)
        {
            if (!parking.ContainsKey(username))
            {
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                parking.Add(username,licensePlateNumber);
            }
            else
            {
                Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
            }
        }
    }
}
