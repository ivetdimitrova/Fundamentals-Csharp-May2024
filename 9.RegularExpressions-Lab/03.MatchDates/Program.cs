using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();

            Regex regex = new Regex(@"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            MatchCollection matches = regex.Matches(dates);
            

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
