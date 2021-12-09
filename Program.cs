using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number.");
            int userInput = 0;

            while (userInput != favNumber)
            {
                Console.WriteLine("Please enter a guess between 1 and 1000.");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again.");

                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Your guess is too high. Try again");

                }
                else
                {
                    Console.WriteLine($"{favNumber} is the correct answer! Congratulations!");
                }

            }

            Console.WriteLine("What's your favorite school subject?");

            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math can be really hard.");
                    break;
                case "science":
                    Console.WriteLine("Science is a very complex subject");
                    break;
                case "history":
                    Console.WriteLine("History is actually my favorite subject too!");
                    break;
                case "english":
                    Console.WriteLine("English is cool, but I could never understand that Shakespeare stuff.");
                    break;
                case "gym":
                    Console.WriteLine("Is gym even a real subject? Welp, to each their own.");
                    break;
                default:
                    Console.WriteLine($"I don't think I had {favSubject} at my school, but it sounds interesting!");
                    break;
            }
        }
    }
}