// See https://aka.ms/new-console-template for more information
using System;

namespace Math {
    class Program {
        static void Main(string[] args) {

            int number = 1;

            float other_number = Convert.ToSingle(number);

            Console.WriteLine(other_number.GetType());
        }
    }
}