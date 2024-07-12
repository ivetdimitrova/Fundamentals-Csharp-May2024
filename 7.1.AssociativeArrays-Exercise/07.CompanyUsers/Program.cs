namespace _07.CompanyUsers
{
    public class Company
    {
        public Company(string name)
        {
            EmployeeIds = new List<string>();
            Name = name;
        }
        public string Name { get; set; }

        public List<string> EmployeeIds { get; set; }

        public void AddEmployee(string employeeId)
        {
            if (!EmployeeIds.Contains(employeeId))
            {
                EmployeeIds.Add(employeeId);
            }
        }

        public override string ToString()
        {
            string result = $"{Name}\n";

            for (int i = 0; i < EmployeeIds.Count; i++)
            {
                result += $"-- {EmployeeIds[i]}\n";
            }

            return result.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] information = input.Split("->").ToArray();

                string name = information[0].Trim();
                string id = information[1].Trim();



                if (!companies.ContainsKey(name))
                {
                    Company company = new Company(name);
                    companies.Add(name, company);
                }

                companies[name].AddEmployee(id);
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Value);
            }
        }
    }
}
