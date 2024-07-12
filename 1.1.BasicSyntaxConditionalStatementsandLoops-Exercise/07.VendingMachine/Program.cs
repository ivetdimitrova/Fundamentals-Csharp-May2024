namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal balance = 0;
            decimal nutsPrice = 2.0m;
            decimal waterPrice = 0.7m;
            decimal crispsPrice = 1.5m;
            decimal sodaPrice = 0.8m;
            decimal cokePrice = 1.0m;
            while ((input = Console.ReadLine()) != "Start")
            {
                // decimal money = decimal.Parse(input);
                switch (input)
                {
                    case "0.1":
                        balance += 0.1m;
                        break;
                    case "0.2":
                        balance += 0.2m;
                        break;
                    case "0.5":
                        balance += 0.5m;
                        break;
                    case "1":
                        balance += 1.0m;
                        break;
                    case "2":
                        balance += 2.0m;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {input}");
                        break;
                }
            }
            while ((input = Console.ReadLine()) != "End")
            {

                switch (input)
                {
                    case "Nuts":
                        if (balance >= nutsPrice)
                        {
                            balance -= nutsPrice;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (balance >= waterPrice)
                        {
                            Console.WriteLine($"Purchased water");
                            balance -= waterPrice;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (balance >= crispsPrice)
                        {
                            Console.WriteLine($"Purchased crisps");

                            balance -= crispsPrice;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (balance >= sodaPrice)
                        {
                            Console.WriteLine($"Purchased soda");

                            balance-= sodaPrice;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (balance >= cokePrice)
                        {
                            Console.WriteLine($"Purchased coke");

                            balance -= cokePrice;

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }



            }
            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}

