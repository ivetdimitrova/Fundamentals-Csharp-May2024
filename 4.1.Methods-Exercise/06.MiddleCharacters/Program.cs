namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            IsEvenLength(str);
            IsOddLength(str);
        }

        static void IsEvenLength(string str)
        {
            if (str.Length % 2 == 0)
            {
                int index = str.Length / 2;

                for (int i = index - 1; i <= +index; i++)
                {
                    Console.Write(str[i]);
                }
            }
        }
        static void IsOddLength(string str)
        {
            if (str.Length % 2 != 0)
            {
                int index = str.Length / 2;

                Console.Write(str[index]);
            }
        }

    }
}
