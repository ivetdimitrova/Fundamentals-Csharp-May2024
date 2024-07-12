namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            string[] commonElements = new string[arr2.Length];
            int index = 0;

            // Итерираме през втория масив
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        commonElements[index++] = arr2[i];
                        break;  // Спираме вътрешния цикъл след намиране на съвпадение
                    }
                }
            }

            // Отпечатваме общите елементи
            if (index > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    Console.Write(commonElements[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No common elements found");
            }

        }
    }
}
