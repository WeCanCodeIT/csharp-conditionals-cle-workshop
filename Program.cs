using System;

namespace csharp_conditionals_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Make Some Decisions!");

            //Console.WriteLine("What is your name?  If your name is the same as mine, I will let you know.");
            //// create variable to save my name
            //string myName = "jen";

            //// read user's response
            //string userName = Console.ReadLine();

            //// compare my name to user's name
            //// if they are the same, print message to screen
            //if (myName.Equals(userName.ToLower()))
            //{
            //    Console.WriteLine("Hey, your name is the same as mine!");
            //}

            //Console.WriteLine("Is it hot or cold outside?");
            //string outsideTemperature = Console.ReadLine();
            //if (outsideTemperature.ToLower().Equals("hot"))
            //{
            //    Console.WriteLine("Yes, it is hot outside");
            //}
            //else
            //{
            //    Console.WriteLine("OK, it's not hot outside");
            //}

            //Console.WriteLine("Enter a number.  I will tell you if it is larger, smaller, or equal to 10");
            //int usersNumber = Convert.ToInt32(Console.ReadLine());

            //if (usersNumber > 10)
            //{
            //    Console.WriteLine("Your number is greater than 10");
            //}
            //else if (usersNumber < 10)
            //{
            //    Console.WriteLine("Your number is less than 10");
            //}
            //else 
            //{
            //    Console.WriteLine("Your number is equal to 10");
            //}

            Console.WriteLine("What kind of pet do you have?  Answer 'none' if you don't have any pets.");
            string myPet = Console.ReadLine();

            if (myPet.Equals("dog"))
            {
                Console.WriteLine("Dogs are nice");
            }
            else if (myPet.Equals("cat"))
            {
                Console.WriteLine("I had a cat once.");
            }
            else if (myPet.Equals("turtle"))
            {
                Console.WriteLine("I have a turtle too, his name is Smash");
            }
            else if (myPet.Equals("none"))
            {
                Console.WriteLine("That's too bad");
            }
            else
            {
                Console.WriteLine("I don't know anything about that kind of pet");
            }

            switch (myPet)
            {
                case "dog":
                    Console.WriteLine("I like dogs");
                    break;
                case "cat":
                    Console.WriteLine("I had a cat once.");
                    break;
                case "turtle":
                    Console.WriteLine("I have a turtle too, his name is Smash");
                    break;
                case "none":
                    Console.WriteLine("That's too bad");
                    break;
                default:
                    Console.WriteLine("I don't know anything about that kind of pet");
                    break;
            }
        }
    }
}
