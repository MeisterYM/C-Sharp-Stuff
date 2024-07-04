// See https://aka.ms/new-console-template for more information

//This code could be improved by creating a function that accepts an array and returns a new one.
//That could be done later, as the point of this exercise was to grasp the main idea of Bubble Sort.

using System;

namespace Bubble_Sort {
    class Program {
        static void Main(string[] args) {

            //Creating an array to test the algorithm.
            int[] thing = {3, 1, 2, 4, 6, 7, 5, 9};

            //Assigning the size of the array to a variable.
            int size = thing.Length;

            //First loop is to keep track of the iteration through the array.
            //It's not enough to just compare everything in the array one time.
            //The number of times that we'll have to iterate through the array and compare things depends on its size.
            for(int i = 0; i < size-1; i++) {

                //Second loop is where the comparing and swapping happens.
                for(int j = 0; j < size - i - 1; j++) {

                    //If the current value in the array is greater than the next value in the array, swap them. Otherwise do nothing.
                    if(thing[j] > thing[j+1]) {
                        int placeholder = thing[j];
                        thing[j] = thing[j+1];
                        thing[j+1] = placeholder;
                    }

                }

            }

            //Printing the values of the array. Should be in increasing order.
            for(int k = 0; k < size; k++) {
                Console.WriteLine(thing[k]);
            }

        }
    }
}