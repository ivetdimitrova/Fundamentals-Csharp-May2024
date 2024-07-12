
namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           List<int> newList = new List<int>(DeleteNegatives(numbers));

           newList.Reverse();
           if (newList.Count > 0)
           {
               Console.WriteLine(String.Join(" ", newList));
           }
           else
           {
               Console.WriteLine("empty");
           }
        } 
        static List<int> DeleteNegatives(List<int> numbers)
        {
            for (int i = 0; i <= numbers.Count-1; i+=0)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                }
                else
                {
                    i++;
                }
            }
            return numbers;
        }
    }
}
