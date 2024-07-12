namespace _04.Students
{
    class Student
    {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split().ToArray();

                TakeStudentInformation(students, information);
            }

            string city = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static void TakeStudentInformation(List<Student> students, string[] information)
        {
            string firstName = information[0];
            string lastName = information[1];
            string age = information[2];
            string homeTown = information[3];

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Age = age;
            student.HomeTown = homeTown;

            students.Add(student);
        }
    }
}
