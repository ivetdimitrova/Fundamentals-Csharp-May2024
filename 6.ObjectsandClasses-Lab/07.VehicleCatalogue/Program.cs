



namespace _07.VehicleCatalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    }

    class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void AddTruck(Truck truck)
        {
            Trucks.Add(truck);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split("/").ToArray();

                switch (information[0])
                {
                    case "Car":
                        TakeCarInfo(information, catalog);
                        break;
                    case "Truck":
                        TakeTruckInfo(information, catalog);
                        break;
                }
                
            }
            Console.WriteLine("Cars:");
            foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");

            foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

            }
        }



        private static void TakeTruckInfo(string[] information, Catalog catalog)
        {
            string brand = information[1];
            string model = information[2];
            int weight = int.Parse(information[3]);

            Truck truck = new Truck(brand,model,weight);

            catalog.AddTruck(truck);
        }

        private static void TakeCarInfo(string[] information, Catalog catalog)
        {
            string brand = information[1];
            string model = information[2];
            int horsePower = int.Parse(information[3]);

            Car car = new Car(brand,model,horsePower);

            catalog.AddCar(car);
        }
    }
}
