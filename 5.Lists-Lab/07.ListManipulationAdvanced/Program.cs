

using System.Reflection.Metadata;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<double> originalLIst = new List<double>(numbers);
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Contains":
                        DoesItContain(command[1],numbers);
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(numbers);
                        break;
                    case "GetSum":
                        PrintSum(numbers);
                        break;
                    case "Filter":
                        NumbersFiltering(command[1], double.Parse(command[2]), numbers);
                        break;
                    case "Add":
                        numbers.Add(double.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(double.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), double.Parse(command[1]));
                        break;
                }
            }
            IsHaveChanges(originalLIst,numbers);

        }

        static void IsHaveChanges(List<double> originalLIst, List<double> numbers)
        {
            bool IsChanged = true;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == originalLIst[i])
                {
                    IsChanged = false;
                }
            }

            if (IsChanged)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            
        }

        static void NumbersFiltering(string sign, double number, List<double> numbers)
        {
            switch (sign)
            {
                case "<":
                    foreach (double element in numbers)
                    {
                        if (element < number)
                        {
                            Console.Write($"{element} ");
                        }
                    }
                    break;
                case ">":
                    foreach (int element in numbers)
                    {
                        if (element > number)
                        {
                            Console.Write($"{element} ");

                        }
                    }
                    break;
                case "<=":
                    foreach (int element in numbers)
                    {
                        if (element <= number)
                        {
                            Console.Write($"{element} ");

                        }
                    }
                    break;
                case ">=":
                    foreach (int element in numbers)
                    {
                        if (element >= number)
                        {
                            Console.Write($"{element} ");

                        }
                    }
                    break;

            }
            Console.WriteLine();
        }

        static void PrintSum(List<double> numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        static void PrintOddNumbers(List<double> numbers)
        {
            List<double> oddNumbers = new List<double>();
            foreach (double number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddNumbers.Add(number);
                }
            }

            Console.WriteLine(String.Join(" ", oddNumbers));
        }

        static void PrintEvenNumbers(List<double> numbers)
         {
             List<double> evenNumbers = new List<double>();
             foreach (double number in numbers)
             {
                 if (number % 2 == 0)
                 {
                     evenNumbers.Add(number);
                 }
             }

             Console.WriteLine(String.Join(" ",evenNumbers));
         }

        static void DoesItContain(string value,List<double> numbers)
        {
            if (numbers.Contains(double.Parse(value)))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
