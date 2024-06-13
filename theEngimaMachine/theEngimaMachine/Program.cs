namespace theEngimaMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;
            while((input = Console.ReadLine())!="Decode")
            {
                string[] splitter = input.Split("|");
                string command = splitter[0];
                switch(command)
                {
                    case "Move":
                        int lettersNumber = int.Parse(splitter[1]);
                        string textToMove = message.Substring(0, lettersNumber);

                        message = message.Remove(0, lettersNumber);
                        message += textToMove;
                        break;
                    case "Insert":
                        int index = int.Parse(splitter[1]);
                        string value = splitter[2];
                        message = message.Insert(index,value);
                        break;
                    case "ChangeAll":
                        string substring = splitter[1];
                        string replacement = splitter[2];
                        message = message.Replace(substring, replacement);
                        break;

                
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}