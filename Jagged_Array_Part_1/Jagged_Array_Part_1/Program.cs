using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array_Part_1
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
            matrix[0] = new int[4] { 1, 2, 3, 4 };

            // The second row should have 2 elements.
            matrix[1] = new int[2] { 5, 6 };

            // The third row should have 3 elements.
            matrix[2] = new int[3] { 7, 8, 9 };

            // Display the matrix for verification
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
