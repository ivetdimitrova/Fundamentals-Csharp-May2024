namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basis = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = Result(basis, power);
            Console.WriteLine(result);
        }

        static double Result(int value, int power)
        {
            
            return Math.Pow(value, power); ;
        }
    }
}
