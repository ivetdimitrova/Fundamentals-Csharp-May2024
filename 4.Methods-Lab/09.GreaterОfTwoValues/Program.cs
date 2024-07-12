using System.Collections.Generic;

namespace _09.GreaterОfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    IntegerType();
                    break;
                case "char":
                    CharType();
                    break;
                case "string":
                    StringType();
                    break;
            }
            
        }

        static void IntegerType()
        {
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());

            if (value1 > value2)
            {
                Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine(value2);
            }
        }
        static void CharType ()
        { 
            char value1 = char.Parse(Console.ReadLine());
            char value2 = char.Parse(Console.ReadLine());

            if ((int)value1 > (int)value2)
            {
                Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine(value2);
            }
        }
        static void StringType()
        {
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            //int end = 0;
            //if (value2.Length > value1.Length)
            //{
            //    end = (int)value2.Length;
            //}
            //else
            //{
            //    end = (int)value1.Length;
            //}

            //for (int i = 0; i < end; i++)
            //{
            //    char symbol1 = value1[i];
            //    char symbol2 = value2[i];

            //    if ((int)symbol1 > (int)symbol2)
            //    {
            //        Console.Write(symbol1);
            //    }
            //    else
            //    {
            //        Console.Write(symbol2);
            //    }
            string result = string.Empty;
            int comparison = value1.CompareTo(value2);
            if (comparison > 0)
            {
                result = value1;
            }
            else
            {
                result = value2;
            }
            Console.WriteLine(result);
        }
            
        }
    }

