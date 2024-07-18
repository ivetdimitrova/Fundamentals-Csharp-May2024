using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
            static void Main(string[] args)
            {
                string phones = Console.ReadLine();

                var regex = @"\+359([ -])2\1\d{3}\1\d{4}\b";

                var phoneMatches = Regex.Matches(phones, regex);

                var matchedPhones = phoneMatches
                    .Cast<Match>()
                    .Select(a => a.Value.Trim())
                    .ToArray();

                Console.WriteLine(String.Join(", ", matchedPhones));


            }
        
    }

}
    

