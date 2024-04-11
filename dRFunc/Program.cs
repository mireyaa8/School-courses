namespace dRFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad4
            List<int> numbers = new List<int>();
            string[] input = Console.ReadLine().Split(' ');
            foreach(string num in input)
            {
                numbers.Add(int.Parse(num));
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                switch(command)
                {
                    case "add":
                        for(int i = 0; i<numbers.Count; i++)
                        {
                            numbers[i] += 1;

                        }
                        break;
                    case "multiply":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] *= 2;

                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] -= 1;

                        }
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;


                }
            }

        }
    }
}