namespace Matrix3x3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int row = 0; row < size[0]; row++)
            {
                int[] element = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = element[col];

                }
            }
            int sum = 0;
            for (int row = 0; row <= size[0]; row++)
            {
                for (int col = 0; col <= size[1]; col++)
                {
                    int console = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] +
                         matrix[row, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 2] + matrix[row + 1, col + 2] +
                         matrix[row + 2, col + 1];
                    if (console > sum)
                    {
                        sum = console;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"");
        }
    }
}