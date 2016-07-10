using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            // Prompt user for their name.
            string userName = Console.ReadLine();
            
            // Greet user before the cheer.
            Console.WriteLine("Get ready for your cheer, " + userName + "!");

            // Loop through each character in userName and print to console along with cheer message.
            foreach (char letter in userName)
            {   
                // Make each letter in userName lower case for cheer.
                string letterToLower = letter.ToString().ToLower();
                string[] vowels = { "a", "e", "i", "o", "u" };
                string correctArticle;
                // Check if each letter is a vowel so we can write proper English.
                if (vowels.Contains(letterToLower))
                    // If true, use "an".
                    {
                        correctArticle = "an";
                    }
                    // If letter is not a vowel, use "a" instead of "an".
                else
                    {
                        correctArticle = "a";
                    }
                Console.WriteLine("Give me " + correctArticle + " " + letterToLower + "...");
            }

            // Display userName in upper case and tell them they are wonderful.
            Console.WriteLine(userName.ToUpper() + "... is GRAND!");
        }
    }
}