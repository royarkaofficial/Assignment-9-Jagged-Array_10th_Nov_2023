using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Declaration and Initialization

            // 1.1 Declare a jagged array of integers named matrix with three rows.
            int[][] matrix = new int[3][];

            // 1.2 Initialize each row of the matrix with different lengths:
            // The first row should have 4 elements.
            matrix[0] = new int[] { 1, 2, 3, 4 };

            // The second row should have 2 elements.
            matrix[1] = new int[] { 5, 6 };

            // The third row should have 3 elements.
            matrix[2] = new int[] { 7, 8, 9 };

            // Task 2: Accessing and Displaying

            // 2.1 Access and store the value of the second element in the first row in a variable named `element`
            int element = matrix[0][1];

            // 2.2 Display the entire `matrix` using a nested loop.
            DisplayMatrix(matrix);

            // Display the value of the second element in the first row
            Console.WriteLine($"Value of the second element in the first row: {element}");

            // Task 3: Modification

            // 3.1 Modify the third element in the second row of the matrix to have a value of 15.
            if (matrix.Length > 1 && matrix[1].Length > 2)
            {
                matrix[1][2] = 15;
            }
            else
            {
                Console.WriteLine("Unable to modify. Insufficient elements in the second row.");
            }

            // Display the matrix after modification
            Console.WriteLine("\nMatrix after modification:");
            DisplayMatrix(matrix);
        }
        static void DisplayMatrix(int[][] matrix)
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write("Row " + (i + 1) + ": ");
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
