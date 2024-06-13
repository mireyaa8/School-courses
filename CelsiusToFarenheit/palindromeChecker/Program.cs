using System.Text.RegularExpressions;

namespace palindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that checks if a string is a palindrome
            //(a string that reads the same forward and backward).
            // madam, pop
            // NOT - traktor



            string[] inpArr = { "m", "a", "d", "a", "m" };
            string[] inpArrReversed = new string[inpArr.Length];
            bool isPalidrome = true;
            for (int i = 0; i < inpArrReversed.Length; i++)
            {
                var reversedIndex = inpArrReversed.Length - 1 - i;
                inpArrReversed[reversedIndex] = inpArr[i];
                if (inpArrReversed[reversedIndex] != inpArr[reversedIndex])
                {
                    Console.WriteLine("not a palindrome");
                    isPalidrome = false;
                    break;
                }
               
            }
            if (isPalidrome == true)
            {
                Console.WriteLine("this word is a palindrome");
            }
        }
    }
}