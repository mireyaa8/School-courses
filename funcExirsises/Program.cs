namespace funcExirsises
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Action<string[]> output = (names) =>
            {
                foreach (var name in names)
                {

                    Console.WriteLine(name);
                    
                }
                

            };
            string input = Console.ReadLine();
            string[] names = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            output(names);


        }
    }
}