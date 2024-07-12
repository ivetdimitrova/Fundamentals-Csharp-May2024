
using System.Threading.Channels;

namespace _06.StoreBoxes
{
    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
               // Box box = new Box();
                string[] information = input.Split().ToArray();
                TakeBoxInformation(boxes, information);
                
            }
            boxes.Sort(((box, box1) => box1.PriceBox.CompareTo(box.PriceBox) ));
            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price :f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox :f2}");
            }
        }

        private static void TakeBoxInformation(List<Box> boxes, string[] information)
        {
           string serialNUmber = information[0];
           string itemName = information[1];
           int quantity = int.Parse(information[2]);
           decimal itemPrice = decimal.Parse(information[3]);
           decimal boxPrice = quantity * itemPrice;

           Box box = new Box();
           box.Item = new Item();
           
           box.SerialNumber = serialNUmber;
           box.Item.Name = itemName;
           box.Quantity = quantity;
           box.Item.Price = itemPrice;
           box.PriceBox = boxPrice;

           boxes.Add(box);
            //decimal max = Decimal.MinValue;
            //int count = 0;
            //if (boxPrice > max)
            //{
            //     boxes.Insert(count,box);
            //}
            //else
            //{
            //    boxes.Add(box);
            //    count++;
        }


    }
}

