namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int inputhours =int.Parse(Console.ReadLine()) ;
           int inputminutes =int.Parse(Console.ReadLine());

            int minutesPlus15 = inputminutes + 30;
            int hours = inputhours + minutesPlus15 / 60;
            int minutes = minutesPlus15 % 60;

            if (hours == 24)
                hours = 0;
            if (minutes < 10)
                Console.WriteLine($"{hours}:0{minutes}");
            else
                Console.WriteLine($"{hours}:{minutes}");

        }
    }
}
