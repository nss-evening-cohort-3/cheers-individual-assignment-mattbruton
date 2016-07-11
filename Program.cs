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
        }
    }
}
