
namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            IsCoffee(product, 1.50,count);
            IsWater(product,1.00,count);
            IsCoke(product,1.40,count);
            IsSnacks(product,2.00,count);
             void IsCoffee(string product, double price, int count)
            {
                if (product == "coffee")
                {
                    double allPrice = price * count;
                    Console.WriteLine($"{allPrice:f2}");
                }
            }

            void IsWater(string product, double price, int count)
            {
                if (product == "water")
                {
                    double allPrice = price * count;
                    Console.WriteLine($"{allPrice:f2}");
                }
            }

            void IsCoke(string product, double price, int count)
            {
                if (product == "coke")
                {
                    double allPrice = price * count;
                    Console.WriteLine($"{allPrice:f2}");
                }
            }

            void IsSnacks(string product, double price, int count)
            {
                if (product == "snacks")
                {
                    double allPrice = price * count;
                    Console.WriteLine($"{allPrice:f2}");
                }
            }
        }

        
    }
}
