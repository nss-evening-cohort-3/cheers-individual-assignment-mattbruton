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
            Console.WriteLine("What's your name?");
            string prompt = "> ";
            Console.Write(prompt);
            string userName = Console.ReadLine();

            string[] vowels = {"a","e","i","o","u"};

            foreach (char letter in userName)
            {
                string letterToLower = letter.ToString().ToLower();
                string properArticle;
                if (vowels.Contains(letterToLower))
                {
                    properArticle = "an";
                }
                else
                {
                    properArticle = "a";
                }
                Console.WriteLine("Give me " + properArticle + " " + letterToLower);
            }
            Console.WriteLine(userName.ToUpper() + " is.. GRAND!");
        }
    }
}
