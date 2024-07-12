namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

           decimal courses = Math.Ceiling((decimal)countOfPeople / capacity);
            Console.WriteLine(courses);
        }
    }
}
