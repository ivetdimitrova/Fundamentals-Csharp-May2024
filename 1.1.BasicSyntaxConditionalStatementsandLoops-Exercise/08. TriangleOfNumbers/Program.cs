﻿namespace _08._TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            //Кoлини
            for(int i = 1; i <= n; i++) 
            {
                //редове
                for(int j = 1;j<=i;j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

        }
    }
}
