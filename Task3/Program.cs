namespace Task3
{
    internal class Program
    {
        static char[,] battleField
        static void Main(string[] args)
        {
            CheckGun( );
            int playerX =0, playerY = 0;
            int enemiesCount = 3;
            int playerHealth = 3;
            int size = int.Parse(Console.ReadLine());
            char[,] battleField = new char[size, size];
            for(int i = 0; i<size; i++)
            {
                string colElements = Console.ReadLine();
                   
                for(int j = 0; j<size; j++)
                {
                    battleField[i,j] = colElements[j];

                    if (colElements[j] == 'p')
                    {
                        playerX= i;
                        playerY= j;
                    }
                }
            }
            while (playerHealth==0|| enemiesCount ==0)
            {
                string move= Console.ReadLine();
                switch(move?.ToLower())
                {
                    case "up":
                        if (battleField[playerY, playerX+1] == 'G')
                        {
                            playerHealth--;
                        }
                        break;
                }
            }
        }
        static bool CheckGun(int playerX,int playerY)
        {
            return battleField[playerX, playerY] == 'G';
        }
        static bool CheckEnemy(int playerX, int playerY)
        {
            return battleField[playerX, playerY] == 'G';
        }

    }
}