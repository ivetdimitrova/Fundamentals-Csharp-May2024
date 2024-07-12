namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int wagons = int.Parse(Console.ReadLine());

            int[] passengers = new int[wagons];

            int allPassengers = 0;
            for (int i = 0; i < wagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                allPassengers += passengers[i];
            }
            Console.WriteLine(String.Join(" ", passengers));
             Console.WriteLine(allPassengers);


        }
    }
}
