using System.Linq.Expressions;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = countOfPeople * 8.45;
                            break;
                        case "Saturday":
                            price = countOfPeople * 9.80;
                            break;
                        case "Sunday":
                            price = countOfPeople * 10.46;
                            break;

                    }
                    if(countOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Business":
                    double discount = 0;
                    switch (day)
                    {
                        case "Friday":
                            price = countOfPeople * 10.90;
                            discount = 10 * 10.90;
                            break;
                        case "Saturday":
                            price = countOfPeople * 15.60;
                            discount = 10 * 15.60;
                            break;
                        case "Sunday":
                            price = countOfPeople * 16;
                            discount = 10 * 16;
                            break;

                    }
                    if (countOfPeople >= 100)
                    {
                        price -= discount;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = countOfPeople * 15;
                            break;
                        case "Saturday":
                            price = countOfPeople * 20;
                            break;
                        case "Sunday":
                            price = countOfPeople * 22.50;
                            break;

                    }
                    if (countOfPeople >= 10 && countOfPeople <=20)
                    {
                        price *= 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
