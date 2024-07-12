namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,double> students = new Dictionary<string,double>();
           Dictionary<string,int> times = new Dictionary<string,int>();

           int count = int.Parse(Console.ReadLine());

           for (int i = 0; i < count; i++)
           {
               string name = Console.ReadLine();
               double grade = double.Parse(Console.ReadLine());

               if (!students.ContainsKey(name))
               {
                   students.Add(name,0);
               }

               if (!times.ContainsKey(name))
               {
                   times.Add(name, 0);
               }

               times[name]++;
               students[name] += grade;
           }

           foreach (var student in students)
           {
               string name = student.Key;
               double grade = student.Value;

               foreach (var time in times)
               {
                   if (time.Key == name)
                   {
                       double averageGrade = grade / time.Value;
                       if (averageGrade >= 4.50)
                       {
                           Console.WriteLine($"{name} -> {averageGrade:f2}");
                       }
                   }
               }
           }
        }
    }
}
