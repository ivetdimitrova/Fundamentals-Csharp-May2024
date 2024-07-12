namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> resources = new Dictionary<string,int>();

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                string resource = input;
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }

                resources[resource] += quantity;
            }

            foreach (var resource1 in resources)
            {
                Console.WriteLine($"{resource1.Key} -> {resource1.Value}");
            }
        }
    }
}
