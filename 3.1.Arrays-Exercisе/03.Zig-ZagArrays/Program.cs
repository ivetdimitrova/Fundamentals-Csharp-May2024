namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraysCount = int.Parse(Console.ReadLine());

            int[] firstArray = new int[arraysCount];
            int[] secondArray = new int[arraysCount];

            int index = 0;
            for (int i = 1; i <= arraysCount; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    for (int j = index; j <= index; j++)
                    {
                        firstArray[index] = numbers[1];
                    }

                    for (int k = index; k <=index; k++)
                    {
                        secondArray[index] = numbers[0];
                    }
                    index++;

                }
                else
                {
                    for (int j = index; j <= index; j++)
                    {
                        firstArray[index] = numbers[0];
                    }
                    for (int k = index; k <= index; k++)
                    {
                        secondArray[index] = numbers[1];
                    }
                    index++;

                }

            }

            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));

        }
    }

}
