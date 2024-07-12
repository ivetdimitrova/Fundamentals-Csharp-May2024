namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            string nameOfBigger = "";

            double max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                string mobel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2)*height;
                if(volume > max)
                {
                    nameOfBigger = mobel;
                    max = volume;

                }
            }
            Console.WriteLine(nameOfBigger);
        }
    }
}
