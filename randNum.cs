// The default code.
using System;

namespace randNum {

    class Program {

        static void Main(string[] args) {

            try {

                // Initializing the random class.
                Random rnd = new Random();

                // Getting the user input.
                Console.Write("Enter the starting number for the range you want the random number to be selected from: ");
                string start = Console.ReadLine();
                int Start = int.Parse(start);

                Console.Write("Enter the ending number for the range you want the random number to be selected from: ");
                string end = Console.ReadLine();
                int End = int.Parse(end);

                // Output.
                if (Start < End) Console.WriteLine($"The random number is {rnd.Next(Start, End)}." + rnd.Next(Start, End) + ".");

                else if (Start > End) Console.WriteLine($"The random number is {rnd.Next(End, Start)}.");

                // Making sure the starting and ending numbers of the range are different.
                else Console.WriteLine("The starting number and the ending number cannot be equal.");

            // If the user enters a strings instead of an integer, this message is printed out instead of the program crashing.
            } catch (FormatException) {
                
                Console.WriteLine("Please enter a valid value");
                
            }

            // Preventing the program from terminating immediately.
            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}