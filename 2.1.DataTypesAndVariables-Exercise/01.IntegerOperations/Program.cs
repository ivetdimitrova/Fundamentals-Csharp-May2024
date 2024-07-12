namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstNUmber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int firstOperation = firstNUmber + secondNumber;
            int secondOperation = firstOperation / thirdNumber;
            int thirdOperation = secondOperation * fourthNumber;

            Console.WriteLine(thirdOperation);
        }
    }
}
