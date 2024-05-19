using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputEmulation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isTest = args.Length > 0 && args[0] == "test";
            int x, y;

            Console.WriteLine("Введите два числа (x и y):");

            // Input for x
            while (true)
            {
                Console.Write("Введите число x: ");
                if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
                }
            }

            // Input for y
            while (true)
            {
                Console.Write("Введите число y: ");
                if (int.TryParse(Console.ReadLine(), out y) && y > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
                }
            }

            // Create and display the multiplication matrix
            int[,] matrix = MatrixOperations.CreateMultiplicationMatrix(x, y);
            MatrixOperations.DisplayMatrix(matrix, x, y);

            // Wait to show output if is running in test mode
            if (!isTest) Console.ReadKey();
        }
    }
}
