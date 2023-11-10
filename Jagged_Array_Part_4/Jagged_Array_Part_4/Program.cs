using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array_Part_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Declaration and Initialization

            // 1.1 Declare and initialize a jagged array named 'objectMatrix' to store objects of different types.
            object[][] objectMatrix = new object[2][];

            // 1.2 Initialize the first row with an integer, a string, and a double.
            objectMatrix[0] = new object[] { 42, "Hello, World!", 3.14 };

            // 1.3 Initialize the second row with a boolean, a character, and a DateTime object.
            objectMatrix[1] = new object[] { true, 'A', DateTime.Now };

            // Task 2: Displaying the 'objectMatrix'

            // 2.1 Display the contents of the 'objectMatrix' using nested loops.
            DisplayObjectMatrix(objectMatrix);
        }
        static void DisplayObjectMatrix(object[][] objectMatrix)
        {
            Console.WriteLine("Object Matrix:");

            for (int i = 0; i < objectMatrix.Length; i++)
            {
                Console.Write("Row " + (i + 1) + ": ");
                for (int j = 0; j < objectMatrix[i].Length; j++)
                {
                    // Display the type and value of each object
                    Console.Write($"({objectMatrix[i][j].GetType().Name}){objectMatrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
