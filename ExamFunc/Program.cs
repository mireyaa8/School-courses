namespace ExamFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naming sir

            string input = Console.ReadLine();
            string[] names = input.Split(' ');
            Action<string[]> add = (string[] arr) =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = "Sir" + arr[i];

                }
            };
            add(names);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }




        }
    }
}