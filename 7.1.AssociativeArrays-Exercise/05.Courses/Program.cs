

using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace _05.Courses
{
    public class Course
    {
        public Course(string name)
        {
            Students = new List<string>();
            Name = name;
        }

        public string Name { get; set; }
        public List<string> Students { get; set; }

        public override string ToString()
        {
            string result = $"{Name}: {Students.Count}\n";

            for (int i = 0; i < Students.Count; i++)
            {
                result += $"--{Students[i]}\n";
            }

            return result.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Course> course = new List<Course>();
            Dictionary<string,Course> courses = new Dictionary<string,Course>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] information = input.Split(":").ToArray();

                TakeInformation(information, courses);
            }

            foreach (KeyValuePair<string, Course> pair in courses)
            {
                Console.WriteLine(pair.Value);
            }
        }


        private static void TakeInformation(string[] information, Dictionary<string, Course> courses)
        {
            string courseName = information[0].Trim();
            string studentName = information[1];

            if (!courses.ContainsKey(courseName))
            {
                Course course = new Course(courseName);
                courses.Add(courseName, course);
            }

            courses[courseName].Students.Add(studentName);
        }
    }
}
