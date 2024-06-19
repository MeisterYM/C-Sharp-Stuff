// See https://aka.ms/new-console-template for more information
using System;

namespace RNG {
    class Program{
        static void Main(string[] args) {

            //Creating an instance of the random class.
            Random rand = new Random();

            //Assigning a random value between 1 and 30 to a variable.
            int day_of_month = rand.Next(1, 30);

            Console.WriteLine("Computer! What day of the month is it?");

            //Printing the assigned random value.
            Console.WriteLine(day_of_month);

        }
    }
}