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
                Console.WriteLine("Give me a " + letterToLower + "...");
            }

            // Display userName in upper case and tell them they are wonderful.
            Console.WriteLine(userName.ToUpper() + "... is GRAND!");
        }
    }
}
