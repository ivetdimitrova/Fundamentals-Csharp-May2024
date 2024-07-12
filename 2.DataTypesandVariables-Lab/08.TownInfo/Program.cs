namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double kilometers = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {kilometers} square km.");
        }
    }
}
