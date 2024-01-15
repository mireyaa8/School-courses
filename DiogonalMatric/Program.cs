namespace DiogonalMatric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse((Console.ReadLine() + Console.ReadLine()));
                }
            }
            int diognalSum = 0;
            for(int i = 0; i < Math.Min(rows,cols); i++)
            {

                diognalSum+= matrix[i, i];
            }
            Console.WriteLine(diognalSum);
        }
    }
}