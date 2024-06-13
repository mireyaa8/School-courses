namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = input[0];
                string secondName = input[2];
                double salary = double.Parse(input[1]);

                list.Add(new Employee { FirstName = firstName, SecondName = secondName, Salary = salary });
                n--;
            }
            foreach (var z in list)
            {
                Console.WriteLine(z.ToString());
            }
            

        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {

            return $"{this.FirstName} {this.SecondName}: {this.Salary:f2}";
        }
    }
}