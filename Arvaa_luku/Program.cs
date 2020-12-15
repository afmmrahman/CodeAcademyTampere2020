using System;

namespace Arvaa_luku
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 20);
            Console.WriteLine("Guess a number between 1 and 20");

            static int Guess(){
                int guess = 0;
                try {
                    guess = int.Parse(Console.ReadLine());
                } catch (Exception){
                    Console.WriteLine("You did not enter valid guess.");
                    guess = Guess();
                }
                return guess;
                
            }

            int tries = 3;
            int numOfTries = 0 ;

            while (true){
                int guess = Guess();
                numOfTries++;
                if(guess == randomNumber){
                    Console.WriteLine("Your guess was correct");
                    break;
                }
                if(guess > randomNumber){
                    Console.WriteLine("Your guess was too high");
                }
                if(guess < randomNumber){
                    Console.WriteLine("Your guess was too low");
                }
                if(numOfTries == tries){
                    Console.WriteLine($"The number is :{randomNumber}");
                    break;
                }
                Console.WriteLine($"You have {tries - numOfTries} tries left. Enter another number: ");
            }

        }

    }
}
