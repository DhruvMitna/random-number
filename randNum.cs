using System;

namespace randNum {

    class Program {

        static void Main(string[] args) {

            try {

                Random rnd = new Random();

                Console.Write("Enter the starting number for the range you want the random number to be selected from: ");
                string start = Console.ReadLine();
                int Start = int.Parse(start);

                Console.Write("Enter the ending number for the range you want the random number to be selected from: ");
                string end = Console.ReadLine();
                int End = int.Parse(end);

                if (Start < End) Console.WriteLine("The random number is " + rnd.Next(Start, End) + ".");

                else if (Start > End) Console.WriteLine("The random number is " + rnd.Next(End, Start) + ".");

                else Console.WriteLine("The starting number and the ending number cannot be equal.");

            } catch (FormatException) {
                
                Console.WriteLine("Please enter a valid value");
                
            }

            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}