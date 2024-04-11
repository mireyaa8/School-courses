namespace destroyerSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimention =Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[dimention[0], dimention[1]];
            for(int row = 0; row<matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col<matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];

                }

            }
            while (true)
            {
                string input = Console.ReadLine();
                if(input?.ToLower() == "cease fire!")
                {
                    int destroyed = 0;
                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        for(int cols = 0; cols < matrix.GetLength(1); cols++)
                        { 
                      
                            if (matrix[rows, cols] <= 0)
                            {
                                destroyed++;
                            }
                        }
                    }
                    double precentDestryed = ((double)destroyed)/ (dimention[1] * dimention[0])*100;
                    Console.WriteLine($"Destroy bunkers {destroyed}");
                    Console.WriteLine($"Damage done: {precentDestryed:F1} %");
                    return;
                }
                string[] data = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int row = int.Parse(data[0]);
                int col = int.Parse(data[1]);
                int strength = char.Parse(data[2]);
                int adjacentStrength = (int)Math.Ceiling((double)strength / 2);

                matrix[row, col] -= strength;
                if(row-1>= 0 && col-1==0)//top left
                {
                    matrix[row - 1, col - 1] -= adjacentStrength;
                }
                if (row + 1 >= 0 && col + 1 < dimention[1] )//top right
                {
                    matrix[row - 1, col + 1] -= adjacentStrength;
                }
                if (row - 1 >=  0)//top
                {
                    matrix[row - 1, col] -= adjacentStrength;
                }
               if (row - 1 >= 0)//left
                {
                    matrix[row , col - 1] -= adjacentStrength;
                }
                if (row - 1 >= 0)//right
                {
                    matrix[row, col+1] -= adjacentStrength;
                }
                if (row +1 < dimention[0])//bottom left
                {
                    matrix[row+1, col - 1] -= adjacentStrength;
                }
                if (row + 1 < dimention[0])//bottom
                {
                    matrix[row + 1,col] -= adjacentStrength;
                }
                if (row + 1 < dimention[0] && col + 1 < dimention[1])//bottom right
                {
                    matrix[row + 1, col+1] -= adjacentStrength;
                }



            }
        }
    }
}