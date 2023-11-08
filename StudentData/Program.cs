namespace StudentData
{
    internal class Program
    {
        void GetStudentsData(string name, int grade) => Console.WriteLine($"{name} is studying in {grade}");
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());

        }
    }
}