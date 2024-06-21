using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndManipulateArray
{
    internal class Program
    {
        /*
        Question 7: Create and Manipulate an Array
        Create an array of integers with the values
        {10, 20, 30, 40, 50}.
        Print the length of the array.
        Change the third element to 35.
        Print all elements in the array.
        */
        static void Main(string[] args)
        {
            int[] integers = { 10, 20, 30, 40, 50 };

            Console.WriteLine($"Length of array: {integers.Length}\n");

            integers[2] = 35;

            Console.WriteLine($"Elements of the array: {String.Join(", ", integers)}\n");

            /*
            for (int x = 0; x < integers.Length; x++)
            {
                Console.Write($"{integers[x]} ");
            }
            */
        }
    }
}
