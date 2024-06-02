// See https://aka.ms/new-console-template for more information
using System;

namespace Linear_Search {

    class Program {

        static void Main(string[] args) {
//Initialize an array and give it values.
int[] thing = {1, 2, 3, 5, 4, 7, 8, 9, 6, 10};

//The number that the algorithm is going to look for.
int lookup = 6;

//Finding the size of the array before running the loop since for some reason using thing.Length in the for loop causes problems.
int size = thing.Length;

//Commented code to test variables and methods.
//Console.WriteLine(size);

//Linear search implementation. Tells you when value is found and where in the array. Otherwise says nothing.
for(int i = 0; i < size; i++) {
    if(lookup == thing[i]) {
        Console.WriteLine("Found it! The index is at " + i + ".");
    }
}
        }
    }
}