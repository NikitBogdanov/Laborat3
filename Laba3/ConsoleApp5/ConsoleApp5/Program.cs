using System;

namespace ConsoleApp5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matrix1 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    matrix1[i, j] = rand.Next(1, 10);
                    Console.Write(matrix1[i, j] + " ");
                }
            }
            Console.WriteLine();
            int[,] matrix2 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    matrix2[i, j] = rand.Next(1, 10);
                    Console.Write(matrix2[i, j] + " ");
                }
            }
            Console.WriteLine();
            int[,] ansver = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        ansver[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(ansver[i, j] + " ");
                }
            }
        }
    }
}
