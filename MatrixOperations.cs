using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputEmulation
{
    public static class MatrixOperations
    {
        public static int[,] CreateMultiplicationMatrix(int x, int y)
        {
            int[,] matrix = new int[y, x];

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix[i, j] = (i + 1) * (j + 1);
                }
            }

            return matrix;
        }

        public static void DisplayMatrix(int[,] matrix, int x, int y)
        {
            Console.WriteLine("[");
            for (int i = 0; i < y; i++)
            {
                Console.Write("[");

                for (int j = 0; j < x; j++)
                {
                    if (j < x - 1)
                    {
                        Console.Write(matrix[i, j] + ", ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j]);
                    }
                }

                if (i < y - 1)
                {
                    Console.WriteLine("],");
                }
                else
                {
                    Console.WriteLine("]");
                }
            }
            Console.WriteLine("]");
        }
    }
}
