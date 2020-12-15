using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVal1, intVal2, result;
            string userInput;

            Console.WriteLine("Enter integer 1: ");
            userInput = Console.ReadLine();
            intVal1 = Convert.ToInt32(userInput);
            Console.WriteLine("Enter integer 2: ");
            userInput = Console.ReadLine();
            intVal2 = Convert.ToInt32(userInput);
            result = intVal1 + intVal2;
            Console.WriteLine("{0} + {1} = {2}", intVal1, intVal2, result);

        }
    }
}
