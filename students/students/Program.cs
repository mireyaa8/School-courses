namespace students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> list = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Students student = new Students(input[0], input[1], double.Parse(input[2]));
                list.Add(student);
            }

            foreach (Students student in list.OrderByDescending(l => l.Grade))
            {
                Console.WriteLine(student.ToString());
            }

        }
    }

    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Students(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName}  {this.LastName}: {this.Grade:f2} ";
        }
    }
}
