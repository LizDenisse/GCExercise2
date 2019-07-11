using System;

namespace GCExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
/*
 * EXERCISE 2DescriptionPrompt the user to enter a number. 
 * After the user enters a number, add 1 to the number andoutput it back to the console.
 * Example
 * >>Enter a number: <<52>>
 * 53
 */
