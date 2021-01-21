using System;

namespace csharp_conditionals_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Make Some Decisions!");

            Console.WriteLine("What is your name?  If your name is the same as mine, I will let you know.");

            // Create a variable to save my name

            string myName = "andy";

            // Read the user's response

            string userName = Console.ReadLine();

            // compare my name to user's name
            // if they're the same print message to screen 

            if (myName.Equals(userName.ToLower()))
            {
                Console.WriteLine("Hey, we have the same name!");
            }

            else
            {
                Console.WriteLine("Nope, our names are different.");
            }

            // ***** New Code Block *******

            Console.WriteLine("Enter a number.  I will tell you if it is larger, smaller, or equal to 10'");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == 10)
            {
                Console.WriteLine("You win!");
            }

            else if (userNumber < 10)
            {
                Console.WriteLine("Number is less than 10!");
            }

            else if (userNumber < 10)
            {
                Console.WriteLine("Number is less than 10!");
            }

            else if (userNumber < 10)
            {
                Console.WriteLine("Number is less than 10!");
            }

            // ***** New Code Block *******

            Console.WriteLine("What kind of pet do you have?  Answer 'none' if you don't have any pets.");

            string myPet = Console.ReadLine();
            myPet.ToLower();

            if (myPet.Equals("dog"))
            {
                Console.WriteLine("I like dogs.");
            }

            else if (myPet.Equals("cat"))
            {
                Console.WriteLine("I have 6 cats.");
            }

            else if (myPet.Equals("turtle"))
            {
                Console.WriteLine("Not crazy about turtles.");
            }

            else if (myPet.Equals("none"))
            {
                Console.WriteLine("That's too bad.");
            }

            else
            {
                Console.WriteLine("Not sure what you mean.");
            }



            switch (myPet)
            {
                case "dog":
                    Console.WriteLine("I like dogs.");
                    break;
                case "cat":
                    Console.WriteLine("I have 6 cats.");
                    break;
                case "turtle":
                    Console.WriteLine("Not crazy about turtles.");
                    break;
                case "none":
                    Console.WriteLine("That's too bad.");
                    break;
                default:
                    Console.WriteLine("Not sure what you mean.");
                    break;

            }
        }
    }
}
