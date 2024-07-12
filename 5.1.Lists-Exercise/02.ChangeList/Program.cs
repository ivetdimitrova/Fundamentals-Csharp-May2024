namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Delete":
                        DeleteAllElements(numbers,int.Parse( command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
                
            }
            Console.WriteLine(String.Join(" ", numbers));
        }

        static void DeleteAllElements(List<int> numbers,int number)
        {
            if (numbers.Contains(number))
            {
                for (int i =0; i< numbers.Count;i++)
                {
                    if (numbers[i] == number)
                    {
                        numbers.Remove(number);
                    }

                }
            }
        }
    }
}

