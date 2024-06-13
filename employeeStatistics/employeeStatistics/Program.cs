using System.Collections.Specialized;
using System.Xml.Linq;

namespace employeeStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for(int i =0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string department = input[2];
                list.Add(new Employee(name, salary, department));
            }
            var avg = list.GroupBy(emp => emp.Department).Select(group => new
            {
                Department = group.Key,
                avgSalary = group.Average(emp => emp.Salary)
            }).OrderByDescending(group => group.avgSalary).First();
            Console.WriteLine($"Highest Average Salary: {avg.Department}");

            var employeesInDepartment = list.Where(emp => emp.Department == avg.Department)
                                                 .OrderByDescending(emp => emp.Salary);

            foreach (var employee in employeesInDepartment)
            {
                Console.WriteLine(employee);
            }
        }
    }
    public class Employee
    {

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name,double salary, string department) 
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public override string ToString()
        {
            return $"{Name}{Salary:f2}";
        }
    }
}