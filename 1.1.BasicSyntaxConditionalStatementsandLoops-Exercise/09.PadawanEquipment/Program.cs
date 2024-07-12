namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 100

          2

            1.0

            2.0

             3.0
            sabresPrice * (studentsCount + 10%) + 
            robesPrice * (studentsCount) + 
            beltsPrice * (studentsCount – freeBelts) 
            1*(3) + 2*(2) + 3*(2) = 13.00
             */
            //double lightsabers = countOfStudents + (countOfStudents * 0.1);
            //цената за всички светлинни мечове
            //double alllightsabersPrice = count
            //decimal allPriceLightSaber = lightsaberPrice * countOfLightSabers;

            //парите които той има 
            decimal money = decimal.Parse(Console.ReadLine());
            // бройките на нещата
            decimal countOfStudents = decimal.Parse(Console.ReadLine());
           decimal countOfLightSabers = Math.Ceiling(countOfStudents + (countOfStudents * 0.1m));
            decimal countOfBelt = Math.Floor(countOfStudents / 6);
            //цената
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine()) * countOfLightSabers;
            decimal robePrice = decimal.Parse(Console.ReadLine()) * countOfStudents;
            decimal beltPrice = decimal.Parse(Console.ReadLine()) *(countOfStudents - countOfBelt);
            //общата цена за всичко
            decimal allPrice = lightsaberPrice + robePrice + beltPrice;

            if(allPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {allPrice}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {Math.Abs(allPrice - money):f2}lv more.");
            }

        }
    }
}
