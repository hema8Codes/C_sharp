

using System.Collections;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    public class A2_Collections_Array
    {   
        static void Main(string[] args)
        {
            // Collections 
            // Generic and Non-Generic Collections in C#

            // A Generic collection is a class that provides type safety
            // Generic Collection is strongly typed while a Non Generic Collection is not strongly typed

            // Array is a data structure which is used to store multiple elements of same type
            // needs (number of elements) in the beginning (while declaring)
            // Array is very lightweight
            // Data in Array will remain in same order as it was during the insertion

            // Single dimension

            int[] rollNumbers = new int[10];

            // Is Array a collection
            // Yes/No
            // Yes, because -
            // - It is used to store n number of records
            // - We can perform lots of operations on Array
            // No, Because - 
            // - it exist in System namespace
            // (As for collection there is separate namespace System.Collections)
            // - Arrayis fixed in size while collections are dynamic in size

            // Multidimensional Array
            Console.WriteLine("\nEnter rows and column of Matrices: ");

            int Rows = Convert.ToInt32(Console.ReadLine());
            int Columns = Convert.ToInt32(Console.ReadLine());

            // Create 2D Arrays with the above size
            int[,] Matrix = new int[Rows, Columns];

            // Input of 2D matrix
            // Enter Matrix Elements
            Console.WriteLine("\n\n Enter Elements of Matrix :  ");

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int noOfRows = Matrix.GetLength(0);
            int noOfCols = Matrix.GetLength(1);

            // Output of 2d Array
            for(int i = 0; i < Matrix.GetLength(0); i++)
            {
                for(int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }
}
