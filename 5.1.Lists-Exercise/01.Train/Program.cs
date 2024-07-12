
namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    AddPeople(wagons, int.Parse(command[0]),maxCapacity);
                }

            }
            Console.WriteLine(String.Join(" ", wagons));
        }

         static void AddPeople(List<int> wagons, int value,int capacity)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + value <= capacity)
                {
                    wagons[i] += value;
                    break;
                }
            }
        }
    }
}
