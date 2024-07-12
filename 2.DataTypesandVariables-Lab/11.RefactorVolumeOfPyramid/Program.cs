namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = Math.Pow(3, -1) * (length*width*height);
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
