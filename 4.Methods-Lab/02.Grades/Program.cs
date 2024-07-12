using System.Threading.Channels;

namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            IsFail(grade);
            IsPoor(grade);
            IsGood(grade);
            IsVeryGood(grade);
            IsExcellent(grade);
            void IsFail(double mark)
            {
                if (mark <= 2.99)
                {
                    Console.WriteLine($"Fail");
                }
            }

            void IsPoor(double mark)
            {
                if (mark>= 3.00 && mark <= 3.49)
                {
                    Console.WriteLine($"Poor");
                }
            }

            void IsGood(double mark)
            {
                if (mark>=3.50&&mark <= 4.49)
                {
                    Console.WriteLine($"Good");
                }
            }

            void IsVeryGood(double mark)
            {
                if (mark >=4.50 && mark <= 5.49)
                {
                    Console.WriteLine($"Very good");
                }
            }

            void IsExcellent(double mark)
            {
                if (mark >= 5.50 && mark <= 6.00)
                {
                    Console.WriteLine($"Excellent");
                }
            }
        }
    }
}
