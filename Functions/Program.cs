// See https://aka.ms/new-console-template for more information

using System;

namespace Funcions {

    class Program {

        static void Main(string[] args) {

            //Hello world but with a function.
            static void Greeting() {
                Console.WriteLine("Hello World! Function edition!");
            }

            //Calling the Greeting function. Commented until I want to actually call it again.
            //Greeting();


            //Taking an input, preferrably a name, and greeting what is entered.
            static void Better_Greeting(string name) {
                Console.WriteLine("Hello " + name + "!");
            }

            //Better_Greeting("person");

            //Taking an age number and using conditionals to say something about it.
            static void Judge(int age) {
                if(age > 18) {
                    Console.WriteLine("You're an adult! And maybe even old...");
                } else {
                    Console.WriteLine("Hope you're ready to grow up!");
                }
            }

            //Judge(19);
        }
    }
}