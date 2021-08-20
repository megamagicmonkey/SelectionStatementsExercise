using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNum = r.Next(1, 1000);
            bool solved = false;
            int userInput;

            while (solved == false) {
                Console.WriteLine("Try to guess my favorite numer! It's 1, or 1000, or anything between!");
                userInput = int.Parse(Console.ReadLine());
                if (userInput > favNum && userInput <= 1000)
                {
                    Console.WriteLine("Too high!");
                }
                else if (userInput < favNum && userInput >= 1)
                {
                    Console.WriteLine("Too low...");
                }
                else if (userInput == favNum)
                {
                    Console.WriteLine("You got it!");
                    solved = true;
                }
                else
                {
                    Console.WriteLine("Just forget it....");
                    solved = true;
                }
            }

            string subject;
            Console.WriteLine("Moving on then.... What's your favorite school subject?");

            subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math? You must be really smart!");
                    break;
                case "Science":
                    Console.WriteLine("Woah! You're not gonna start cloning dinsoaurs though, right?");
                    break;
                case "English":
                    Console.WriteLine("Me fail English? That's unpossible! But I bet you sure didn't!");
                    break;
                case "Gym":
                    Console.WriteLine("Health sure is important!");
                    break;
                case "History":
                    Console.WriteLine("I bet you learned a lot about wars.");
                    break;
                default:
                    Console.WriteLine("Ah, I'm not sure I know what that is. Sorry!");
                    break;
            }

        }
    }
}
