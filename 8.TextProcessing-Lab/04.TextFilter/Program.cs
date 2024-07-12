﻿namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
                .Split(","); 

            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                string word = banWord.Trim();
                if (text.Contains(word))
                {
                    text = text.Replace(word,
                        new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
