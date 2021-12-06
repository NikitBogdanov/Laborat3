using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица: ");
            Random rand = new Random();
            int[,] Matrix = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Matrix[i, j] = rand.Next(1, 9);
                    Console.Write(Matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Отображение матрицы симметрично, относительно главной диагонали");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    var temp = Matrix[i, j];
                    Matrix[i, j] = Matrix[j, i];
                    temp = Matrix[j, i];
                    Console.Write(temp + " ");
                }
            }
        }
    }
}
