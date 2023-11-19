namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const char UnderScore = '_';
            const string WinText = @"
┌───────────────────────────┐
│                           │
│ WW       WW  **  NN   N   │
│ WW       WW  ii  NNN  N   │
│  WW  WW WW   ii  N NN N   │
│   WWWWWWW    ii  N  NNN   │
│    WW  W     ii  N   NN   │
│                           │
│         Good job!         │
│   You guessed the word!   │
└───────────────────────────┘
";
            const string LoseText = @"
┌────────────────────────────────────┐
│  LLL          OOOO    SSSS   SSSS  │
│  LLL         OO  OO  SS  SS SS  SS │
│  LLL        OO    OO SS     SS     │
│  LLL        OO    OO  SSSS   SSSS  │
│  LLL        OO    OO     SS     SS │
│  LLLLLLLLLL  OO  OO  SS  SS SS  SS │
│   LLLLLLLLL   OOOO    SSSS   SSSS  │
│                                    |
│        You were so close.          │
│ Next time you will guess the word! │
└────────────────────────────────────┘
";
            string[] WrongGuesses =
               {
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"       \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══"  };
            string[] deathAnimationFrames = {
                    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      /   ║   " + '\n' +
    @"      \   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    |__   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    \__   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"   ____   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"    __    ║   " + '\n' +
    @"   /══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    _ '   ║   " + '\n' +
    @"  _/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══"

            };
      
            static string[] ReadWordsFromFile()
            {
                string currentDictenary = Directory.GetCurrentDirectory();

                string projectDirectory = Directory.GetParent(currentDictenary).Parent.Parent.FullName;
                const string WordsFileName = "words.txt";

                string path = $@"{projectDirectory}\{WordsFileName}";

                string[] words = File.ReadAllLines(path);

                return words;
            }
            void playGame(string word, string wordToGuess, int incorrectGuessCount, List<char> playerUsedLetters)
            {
                while (true)
                {
                    string playerInput = Console.ReadLine().ToLower();
                    if (playerInput.Length != 1)
                    {
                        DrawCurrentGameState(true, incorrectGuessCount, wordToGuess, playerUsedLetters);
                        continue;
                    }
                    char playerLetter = char.Parse(playerInput);
                    playerUsedLetters.Add(playerLetter);
                    bool playerLetterIsContained = CheckIfSymbolIsContained(word, playerLetter);
                    if (playerLetterIsContained)
                    {
                        wordToGuess = AddLettertoGuessed(word, playerLetter, wordToGuess);
                    }
                    else
                    {
                        incorrectGuessCount++;
                    }
                    DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);
                    char Underscore = char.Parse("_");
                    bool playerWin = CheckIfPlayerWins(wordToGuess, Underscore);
                    if (playerWin)
                    {
                        Console.Clear();
                        Console.WriteLine(WinText);
                        Console.WriteLine($"The word you guessed [{word}].");
                        break;
                    }
                    bool playerLoses = CheckIfPlayerLooses(incorrectGuessCount);
                    if (playerLoses)
                    {
                        Console.SetCursorPosition(0, 0);
                        DrawDeathAnimation(deathAnimationFrames);
                        Console.Clear();
                        Console.WriteLine(LoseText);
                        Console.WriteLine($"The word you guessed is [{word}]");
                        break;
                    }

                }
                Console.WriteLine("If you want to play again, press [Enter]. Else, type 'quit':");
                 string continuee = Console.ReadLine();
                if (continuee == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("Thamk you for playing! Hangman was closed.");
                    return;
                }
                Console.Clear();

            }
            static bool CheckIfSymbolIsContained(string word, char playerLetter)
            {
                if (!word.Contains(playerLetter))
                {
                    return false;
                }
                return true;

            }
            static string AddLettertoGuessed(string word, char playerLetter, string wordToGuess)
            {
                char[] wordToGuessCharArr = wordToGuess.ToCharArray();
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (playerLetter == word[i])
                    {
                        wordToGuessCharArr[i] = playerLetter;
                    }
                }
                return new String(wordToGuessCharArr);
            }
            static bool CheckIfPlayerWins(string wordToGuess, char Underscore)
            {
                if (wordToGuess.Contains(Underscore))
                {
                    return false;
                }
                return true;
            }
            static bool CheckIfPlayerLooses(int inccorectGuessCount)
            {
                const int MaxAllowedIncorrectCharecters = 6;
                if (inccorectGuessCount == MaxAllowedIncorrectCharecters)
                {
                    return true;
                }
                return false;
            }
            static void DrawDeathAnimation(string[] deathAnimation)
            {
                for (int i = 0; i < deathAnimation.Length; i++)
                {
                    Console.WriteLine(deathAnimation[i]);
                    Thread.Sleep(100);
                    Console.SetCursorPosition(0, 0);
                }
            }
            static string GetRandomWord(string[] words)
            {
                Random var = new Random();
                string word = words[var.Next(words.Length)];
                return word.ToLower();

            }
            void DrawCurrentGameState(bool inputIsInvalid, int incAnswer, string wordToGuess, List<char> usedLetters)
            {

                Console.Clear();
                Console.WriteLine(WrongGuesses[incAnswer]);
                Console.WriteLine($"Guess: {wordToGuess}");
                Console.WriteLine($"You have to guess {wordToGuess.Length} symbols.");
                Console.WriteLine($"The following letters are used: {String.Join(", ", usedLetters)}");
                if (inputIsInvalid)
                {
                    Console.WriteLine("You should type only a single character!");

                }
                Console.Write("Your symbol: ");
            }
            while (true)
            {
                string[] words = ReadWordsFromFile();
                Console.CursorVisible = false;
                string word = GetRandomWord(words);
                char Underscore = char.Parse("_");
                string wordToGuess = new(Underscore, word.Length);
                int inccorectGuessCount = 0;
                List<char> playerUsedLetters = new List<char>();
                DrawCurrentGameState(false, inccorectGuessCount, wordToGuess, playerUsedLetters);
                playGame(word, wordToGuess, inccorectGuessCount, playerUsedLetters);
                Console.WriteLine("If you want to play again, press [Enter]. Else, type 'quit':");
                string continuee = Console.ReadLine();
                if (continuee == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("Thamk you for playing! Hangman was closed.");
                    return;
                }
                Console.Clear();
            }
        }
    }
}