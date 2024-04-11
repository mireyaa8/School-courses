namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();
            while(true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] parts = line.Split(" -> ");
                string company = parts[0];
                string employeeId = parts[1];

                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees[company] = new List<string>();
                }

                if (!companyEmployees[company].Contains(employeeId))
                {
                    companyEmployees[company].Add(employeeId);
                }

            }
            var sorted = companyEmployees.OrderBy(pair => pair.Key); 
            foreach(var pair in sorted)
            {
                Console.WriteLine(pair.Key);
                foreach(var employeeId in pair.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}