
namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string[] information = Console.ReadLine().Split().ToArray();
                TakeStudentInformation(students, information);
            }

         
            students.Sort(((student, student1) => student1.Grade.CompareTo(student.Grade)));

            foreach(Student student in students) 
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

        private static void TakeStudentInformation(List<Student> students, string[] information)
        {
           Student student = new Student();

           student.FirstName = information[0];
           student.LastName = information[1];
           student.Grade = double.Parse(information[2]);

           students.Add(student);
        }
    }
}
