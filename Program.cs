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

            string prompt = "> ";
            char delimiter = '/';
            int currentYear = DateTime.Today.Year;
            DateTime date1 = DateTime.Today;
            

            // Prompt user for their name.
            Console.Write(prompt);
            string userName = Console.ReadLine();

            Console.WriteLine("When is your birthdate?");

            Console.Write(prompt);
            string userDateInput = Console.ReadLine();
            string[] dateInfo = userDateInput.Split(delimiter);
            int userMonth = Int32.Parse(dateInfo[0]);
            int userDay = Int32.Parse(dateInfo[1]);
            
            while (userMonth > 12 || userDay > DateTime.DaysInMonth(currentYear, userMonth))
            {   
                Console.WriteLine("Please enter a valid date.");
                Console.Write(prompt);
                userDateInput = Console.ReadLine();
                dateInfo = userDateInput.Split(delimiter);
                userMonth = Int32.Parse(dateInfo[0]);
                userDay = Int32.Parse(dateInfo[1]);
            }
            
            // Greet user before the cheer.
            Console.WriteLine("Get ready for your cheer, " + userName + "!");

            // Loop through each character in userName and print to console along with cheer message.
            foreach (char letter in userName)
            {   
                // Make each letter in userName lower case for cheer.
                string letterToLower = letter.ToString().ToLower();
                string vowelSounds =  "halfnorsemix";
                string correctArticle;

                // Check if each letter is a vowel so we can write proper English.
                if (vowelSounds.Contains(letterToLower))
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

            
           

            // Splitting the user input from their birthdate to make an array of two items. Split on the '/'.
            

            

            // Should return current year, input before /, input after /
            DateTime date2 = new DateTime(currentYear, userMonth, userDay);

            // Checking to see if the user's birthday has already passed in the current year
            if (DateTime.Compare(date1, date2) == 1)
            {
                // Birthday has passed, checking against the following year
                currentYear = DateTime.Today.Year + 1;
            }

            // Might be able to do away with this in refactoring -- had to check date2 again after conditional
            date2 = new DateTime(currentYear, userMonth, userDay);

            // Subtract the number of days between furthest date (date2) and today's date (date1)
            TimeSpan daysTil = date2.Subtract(date1);
            
            // If today's date is user's birthday, send them a special message!
            if (daysTil.Days.ToString() == "0")
            {
                Console.WriteLine("It's your birthday!");
            }
            // If not, let them know how many days until their birthdate.
            else 
            {
                Console.WriteLine("There are " + daysTil.Days.ToString() + " days til your next birthday.");
            }
        }
    }
}