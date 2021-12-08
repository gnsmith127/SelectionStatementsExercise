using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var r = new Random();
            var favNumber = r.Next(1,1000);

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

            
            
        }
    }
}