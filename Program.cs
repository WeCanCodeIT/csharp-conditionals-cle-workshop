using System;

namespace csharp_conditionals_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Make Some Decisions!");

            Console.WriteLine("What is your name?  If your name is the same as mine, I will let you know.");
            // create variable to save my name
            string myName = "jen";

            // read user's response
            string userName = Console.ReadLine();

            // compare my name to user's name
            // if they are the same, print message to screen
            if (myName.Equals(userName.ToLower()))
            {
                Console.WriteLine("Hey, your name is the same as mine!");
            }

            Console.WriteLine("Is it hot or cold outside?");
            string outsideTemperature = Console.ReadLine();
            if (outsideTemperature.ToLower().Equals("hot"))
            {
                Console.WriteLine("Yes, it is hot outside");
            }
            else
            {
                Console.WriteLine("OK, it's not hot outside");
            }

            // Console.WriteLine("Enter a number.  I will tell you if it is larger, smaller, or equal to 10'");

            // Console.WriteLine("What kind of pet do you have?  Answer 'none' if you don't have any pets.");
        }
    }
}
