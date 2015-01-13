using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World");

            // Step 1: Getting user's name and print it.
            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Welcome, " + name);
            string upperName = name.ToUpper();

            // Step 2: Cheer the user on.
            // If name is "Bob", output should be:
            // Give me a.. b
            // Give me an.. o
            // Give me a.. b
            // BOB is.. GRAND!
            foreach (char letter in name.ToLower())
            {
                string article = "a";
                if("halfnorsemix".IndexOf(letter) >= 0){
                    article = "an";
                }
                System.Console.WriteLine("Give me "+ article + ".. " + letter);
            }
            
            System.Console.WriteLine(upperName + " is.. GRAND!");

            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
