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

            //Variables section
            string prompt = "> ";
            string cheerPrefix = "Give me a";
            string vowelArticleFix;


            Console.WriteLine("What's your name?");
            
            Console.Write(prompt);
            string userName = Console.ReadLine();

            string[] vowels = {"a","e","i","o","u"};

            // Example of base for loop.
            // for (int i = 0; i < userName.Length; i++)  
            // {
            //     Console.WriteLine(userName[i]);
            // }

            foreach (char letter in userName)
            {
                string letterToLower = letter.ToString().ToLower();
                if (vowels.Contains(letterToLower))
                {
                    vowelArticleFix = "n";
                }
                else
                {
                    vowelArticleFix = "";
                }
                Console.WriteLine(cheerPrefix + vowelArticleFix + " " + letterToLower);
            }
            Console.WriteLine(userName.ToUpper() + " is.. GRAND!");
        }
    }
}
