using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the user input
            string userInput;

            // Prompt user to enter in a string to see if it's a palindrome
            Console.WriteLine("Enter in a string to see if it's a palindrome");

            // Assigning the user's input to the userInput variable
            userInput = Console.ReadLine().ToLower();

            // Re-assign user's input to userInputNormalized, which is taking out the spaces
            var userInputNormalized = Regex.Replace(userInput, @"\s", "");

            // Creates a character array for the userInputNormalized
            char[] charArray = userInputNormalized.ToCharArray();

            // Reverses array of characters in string
            Array.Reverse(charArray);

            // Check to see if the reverse of the user's input is the exact same as their original input
            string Txt = string.Empty;
            for (int i = 0; i < charArray.Length; i++)
            {
                Txt += charArray.GetValue(i);
            }

            if (userInputNormalized == Txt)
            {
                Console.WriteLine("Congrats! Your input is a palindrome!");
            }
            else
            {
                Console.WriteLine("Sorry, your input is not a palindrome");
            }

            Console.ReadLine();
        }
    }
}
