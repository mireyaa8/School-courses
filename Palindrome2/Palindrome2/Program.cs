namespace Palindrome2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] inputArr = { "m", "a", "d", "a", "m" };
            string[] wrongArr = { "c", "e", "l", "e", "s", "t" };
            CheckPalindrom(inputArr);
            CheckPalindrom(wrongArr);           
            
        }

        private static void CheckPalindrom(string[] inputArr)
        {         
            bool isPalindromTrue = false;
            for (int i = 0; i < inputArr.Length; i++)
            {                
                var reversedIndx = inputArr.Length - i - 1;
                string opositeLetter = inputArr[reversedIndx];
               //putArr[i] = opositeLetter;
                if (opositeLetter == inputArr[i])
                {
                    isPalindromTrue = true;
                    Console.WriteLine("This is a palindrome");
                    break;
                }
            }
            if (isPalindromTrue == false)
                
            {
                Console.WriteLine("Not a palindrome");
               
            }

        }
    }
}