namespace Grades
{
    internal class Program
    {
        static void Print(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Invalid grade. Grade should be between 2.00 and 6.00.");
            }
        
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the grade: ");
            if(double.TryParse(Console.ReadLine(), out double grade))
            {
                Print(grade);

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid grade as a number.");
            }
        }
    }
}