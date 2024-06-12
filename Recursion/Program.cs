// See https://aka.ms/new-console-template for more information

using System;

namespace Recursion {
    class Program {
        static void Main(string[] args) {

            //As long as the given number is greater than 0, the function will call itself and decrease said number by 1.
            static int countdown(int number) {
                if(number < 0) {
                    Console.WriteLine("I can't do a countdown with that number!");
                    return 0;
                } else if(number > 0) {
                    Console.WriteLine(number);
                    return countdown(number - 1);
                } else {
                    Console.WriteLine("Liftoff!");
                    return 0;
                }
            }

            //Calling the function with a given number.
            countdown(0);

        }

    }

}