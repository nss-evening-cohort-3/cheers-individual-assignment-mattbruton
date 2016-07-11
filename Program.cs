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

            Console.WriteLine("When is your birthdate?");

            string userDateInput = Console.ReadLine();
            
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

            int currentYear = DateTime.Today.Year;
            
            DateTime date1 = DateTime.Today;

            char delimiter = '/';
            string[] dateInfo = userDateInput.Split(delimiter);

            int userMonth = Int32.Parse(dateInfo[0]);
            int userDay = Int32.Parse(dateInfo[1]);

            DateTime date2 = new DateTime(currentYear, userMonth, userDay);

            if (DateTime.Compare(date1, date2) == 1)
            {
                Console.WriteLine("fix plz");
                currentYear = DateTime.Today.Year + 1;
            }

            date2 = new DateTime(currentYear, userMonth, userDay);
            TimeSpan daysTil = date2.Subtract(date1);
            
            if (daysTil.Days.ToString() == "0")
            {
                Console.WriteLine("It's your birthday!");
            }
            else 
            {
                Console.WriteLine("There are " + daysTil.Days.ToString() + " days til your next birthday.");
            }
        }
    }
}