namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int numGrades = int.Parse(Console.ReadLine());

            for (int i = 0; i < numGrades; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                string name = input[0];
                double grade = double.Parse(input[1]);
                if(students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students[name] = new List<double> { grade};
                }
            }
            foreach(var kvp in students)
            {
                string name = kvp.Key;
                List<double> grades = kvp.Value;
                double averageGrade = grades.Average();
                string gradesStr = string.Join(" ", grades.Select(g => g.ToString("0.00")));
                Console.WriteLine($"{name} -> {gradesStr} (avg: {averageGrade.ToString("0.00")})");
            }


        }
    }
}