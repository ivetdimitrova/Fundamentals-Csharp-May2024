namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(firstNumber,secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber,secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber,secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber,secondNumber);
                    break;
            }
            void Add( double a, double b)
            {
                Console.WriteLine(a + b);
            }

            void Multiply( double a, double b)
            {
                Console.WriteLine(a * b);
            }

            void Subtract( double a, double b)
            {
                Console.WriteLine(Math.Abs(a - b));
            }

            void Divide( double a, double b)
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
