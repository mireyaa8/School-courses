namespace HWsnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimention = Console.ReadLine()
                .Split();
            int n = int.Parse(dimention[0]);
            int m = int.Parse(dimention[1]);
            string snake = Console.ReadLine();

            char[,] matrix =  new char[n, m];
            int index = 0;
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < m; col++)
                {
                    matrix[row,col] = snake[index++%snake.Length];
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.WriteLine(matrix[row,col]);
                }
                Console.WriteLine();
            }


        }
    }
}