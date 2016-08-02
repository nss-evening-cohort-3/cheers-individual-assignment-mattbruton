using System;

namespace Cheers
{
    public class Questions {

        public static string userName;
        public static string userDateInput;
        public static string prompt = "> ";
        public static void AskName() {
            Console.WriteLine("What is your name?");
            Console.Write(prompt);
            userName = Console.ReadLine();
        }
        public static void AskBirthdate() {
            Console.WriteLine("When is your birthdate?");
            Console.Write(prompt);
            userDateInput = Console.ReadLine();
        }
    }

    public class CheerGenerator {
        public static void Cheer(){
            // Greet user before the cheer.
            Console.WriteLine("Get ready for your cheer, " + Questions.userName + "!");
            foreach (char letter in Questions.userName)
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
                else {
                    correctArticle = "a";
                }
                    
                Console.WriteLine("Give me " + correctArticle + " " + letterToLower + "...");
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Questions.AskName();
            Questions.AskBirthdate();

            char delimiter = '/';
            int currentYear = DateTime.Today.Year;
            DateTime date1 = DateTime.Today;
            
            while (Questions.userDateInput.Contains("/") == false || Questions.userDateInput.Length > 5)
            {
                Console.WriteLine("Please enter a valid date. For example : 12/31");
                Console.Write(Questions.prompt);
                Questions.userDateInput = Console.ReadLine();
            }
            string[] dateInfo = Questions.userDateInput.Split(delimiter);
            int userMonth = Int32.Parse(dateInfo[0]);
            int userDay = Int32.Parse(dateInfo[1]);
            
            while (userMonth > 12 || userDay > DateTime.DaysInMonth(currentYear, userMonth))
            {   
                Console.WriteLine("Please enter a valid date. For example : 12/31");
                Console.Write(Questions.prompt);
                Questions.userDateInput = Console.ReadLine();
                dateInfo = Questions.userDateInput.Split(delimiter);
                userMonth = Int32.Parse(dateInfo[0]);
                userDay = Int32.Parse(dateInfo[1]);
            }

            CheerGenerator.Cheer();

            // Display userName in upper case and tell them they are wonderful.
            Console.WriteLine(Questions.userName.ToUpper() + "... is GRAND!");

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