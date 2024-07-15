namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\")
                .ToArray();

            string[] file = input[input.Length-1]
                .Split(".")
                .ToArray();

            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
