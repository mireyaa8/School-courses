using static System.Net.Mime.MediaTypeNames;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string UnderScore = "";
            const string WinText =
@"┌───────────────────────────┐" +
@"│ │" +
@"│ WW WW **NN N │" +
@"│ WW WW ii NNN N │" +
@"│ WW WW WW ii N NN N │" +
@"│ WWWWWWW ii N NNN │" +
@"│ WW W ii N NN │" +
@"│ │" +
@"│ Good job! │" +
@"│ You guessed the word! │" +
@"└───────────────────────────┘";

            const string LoseText =
@"┌────────────────────────────────────┐
│ LLL OOOO SSSS SSSS │
│ LLL OO OO SS SS SS SS │
│ LLL OO OO SS SS │
│ LLL OO OO SSSS SSSS │
│ LLL OO OO SS SS │
│ LLLLLLLLLL OO OO SS SS SS SS │
│ LLLLLLLLL OOOO SSSS SSSS │
│ |
│ You were so close. │
│ Next time you will guess the word! │
└────────────────────────────────────┘";

            const string WrongGuesses =
@"╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" ║ " + "\n" +
@" ║ " + "\n" +
@" ║ " + "\n" +
@" ███ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@" ║ " + "\n" +
@" ███ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" | ║ " + "\n" +
@" ║ " + "\n" +
@" ███ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" |\ ║ " + "\n" +
@" ║ " + "\n" +
@" ███ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" ║ " + "\n" +
@" ███ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" \ ║ " + "\n" +
@" ███ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" / \ ║ " + "\n" +
@" ███ ║ " + "\n" +
@" ══════╩═══";
            const string deathAnimationFrames =
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" / \ ║ " + "\n" +
@" ███ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" / \ ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o & gt; ║ " + "\n" +
@" /| ║ " + "\n" +
@" &gt;\ ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" / \ ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" &lt; o ║ " + "\n" +
@" |\ ║ " + "\n" +
@" / &lt; ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" / \ ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o & gt; ║ " + "\n" +
@" /| ║ " + "\n" +
@" &gt;\ ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o & gt; ║ " + "\n" +
@" /| ║ " + "\n" +
@" &gt;\ ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" / \ ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" &lt;o ║ " + "\n" +
@" |\ ║ " + "\n" +
@" /&lt; ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" &lt;o ║ " + "\n" +
@" |\ ║ " + "\n" +
@" /&lt; ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" &lt;o ║ " + "\n" +
@" |\ ║ " + "\n" +
@" /&lt; ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" /|\ ║ " + "\n" +
@" / \ ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o ║ " + "\n" +
@" | ║ " + "\n" +
@" | ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o ║ " + "\n" +
@" | ║ " + "\n" +
@" | ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o ║ " + "\n" +
@" | ║ " + "\n" +
@" | ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o ║ " + "\n" +
@" | ║ " + "\n" +
@" | ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o ║ " + "\n" +
@" | ║ " + "\n" +
@" | ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" o ║ " + "\n" +
@" | ║ " + "\n" +
@" | ║ " + "\n" +
@" ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@" | ║ " + "\n" +
@" | ║ " + "\n" +
            @" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@" / ║ " + "\n" +
@" \ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@"  ║ " + "\n" +
@" ║ " + "\n" +
@" |__ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" . ║ " + "\n" +
@" ║ " + "\n" +
@" \__ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@"  ║ " + "\n" +
@" ____ ║ " + "\n" +
@" ══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@"  ║ " + "\n" +
@" . ║ " + "\n" +
@" __ ║ " + "\n" +
@" /══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" . ║ " + "\n" +
@" ║ " + "\n" +
@" _  ║ " + "\n" +
@" _/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@"  ║ " + "\n" +
@" _ ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@"  ║ " + "\n" +
@" . ║ " + "\n" +
@" ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" . ║ " + "\n" +
@" ║ " + "\n" +
@"  ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@"  ║ " + "\n" +
@" _ ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@"  ║ " + "\n" +
@" . ║ " + "\n" +
@" ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" . ║ " + "\n" +
@" ║ " + "\n" +
@"  ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@"  ║ " + "\n" +
@" _ ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@" . ║ " + "\n" +
@" ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@" ║ " + "\n" +
@"  ║ " + "\n" +
@" __/══════╩═══" +
@" ╔═══╗ " + "\n" +
@" | ║ " + "\n" +
@" O ║ " + "\n" +
@" ║ " + "\n" +
@" ║ " + "\n" +
@" _ ║ " + "\n" +
@" __/══════╩═══";


            static string[] ReadWordsFromFile()
            {
                const string WordsFileName = "words.text";

                string currentDictenary = Directory.GetCurrentDirectory();

                string projectDirectory = Directory.GetParent(currentDictenary).Parent.Parent.FullName;


                string path = $@"{projectDirectory}\{WordsFileName}";

                string[] words = File.ReadAllLines(path);
               
                return words;
            }



            string[] words = ReadWordsFromFile();

            Console.CursorVisible = false;

            while(true)
            {
                string word = GetRandomWord(words);

                char underScore = char.Parse("_");

                string wordToGuess = new(underScore, word.Length);
            }
            int incorrectGuessCount = 0;


            List<char> playerUsedLetters = new List<char>();
            

        }

        int incorrectGuessCount = 0;

        List<char> playerUsedLetters = new List<char>();


        

        void PlayGame(string word, string wordToGuess,

            int incorrectGuessCount, List<char> playerUsedLetters)


        {
            PlayGame(word, wordToGuess, incorrectGuessCount, playerUsedLetters);

            Console.Write("If you want to play again, press [Enter], Else, type 'quit': ");

            string PlayerGuess = Console.ReadLine();

            if(PlayerGuess == "quit")
            {
                Console.Clear();

                Console.WriteLine("Thank you for playing! Hangman was closed.");

                return;
            }
            Console.Clear() ;


            while(true)
            {
                // string word = GetRandomWord(words);
                // string WordToGuess = new(Underscore, word.Length);

                //int incorrectGuessCount =0;

                //List<char> playerUsedLetters = new List<char>();

               // DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters) ;

                //PlayerGame(word, wordToGuess, incorrectGuessCount, playerUsedLetters);

                //Console.WriteLine("If you want to play again, press [Enter], Else, type 'exit': ");
                //string playerInput = Console.ReadLine();

                //if(playerInput == "exit")
                //{
                  // Console.Clear();
                   // Console.WriteLine("Thank you for playing! Hangman was closed.");
                   // break;
                //}
               // Console.Clear() ;

            }


            string GetRandomWord(string[] words)
            {
                Random var = new Random();

                string word = words[var.Next(words.Length)];

                return word.ToLower();

            }



            void DrawCurrentGameState(bool inputIsValid, int incorrectGuess,
           string guessedWord, List<char> playerUsedLetters)

            {
                Console.Clear();

                Console.WriteLine(wrongGuessesFrames[incorrectGuessesCount]);


                Console.WriteLine($"Guess: {guessedWord}");

                Console.WriteLine($"You have to guess {guessedWord.Length} symbols. ");

                Console.WriteLine($"The followig letters are used: {String.Join(",", playerUsedLetters)}");


                if(inputIsValid ) 
                {
                    Console.WriteLine("You should type only a single character!");
                }
                Console.Write("Your symbol: ");

                while (true)
                {
                    string word = GetRandomWord(words);

                    string wordToGuess = new(Underscore, word.Length);


                }
            }



            

        }









        
                













    }
}