

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbersList2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (numbersList.Count > numbersList2.Count)
            {
                TheFirstListIsLonger(numbersList, numbersList2);
            }
            else
            {
                TheSecondListIsLonger(numbersList, numbersList2);
            }
        }
        static void TheSecondListIsLonger(List<int> numbersList, List<int> numbersList2)
        {
            List<int> consolidatedList = new List<int>();
            for (int i = 0; i < numbersList2.Count; i++)
            {
                if (i < numbersList.Count)
                {
                    consolidatedList.Add(numbersList[i]);
                    consolidatedList.Add(numbersList2[i]);
                }
                else
                {
                    consolidatedList.Add(numbersList2[i]);
                }
            }
            Console.WriteLine(String.Join(" ",consolidatedList));
        }

        static void TheFirstListIsLonger(List<int> numbersList, List<int> numbersList2)
        {
            List<int> consolidatedList = new List<int>();
            for (int i = 0; i <numbersList.Count ; i++)
            {
                if (i < numbersList2.Count)
                {
                    consolidatedList.Add(numbersList[i]);
                    consolidatedList.Add(numbersList2[i]);
                }
                else
                {
                    consolidatedList.Add(numbersList[i]);
                }
            }
            Console.WriteLine(String.Join(" ", consolidatedList));
        }
    }
}
