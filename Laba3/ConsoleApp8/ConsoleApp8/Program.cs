using System;

namespace Number
{
    class Program
    {
        public static double[,] Minor(double[,] matrix, int minusCol, int minusRow)
        {

            double[,] output = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            int e = 0, k = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                k = 0;
                if (i == minusCol)
                {
                    continue;
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (j == minusRow)
                    {
                        continue;
                    }
                    output[e, k] = matrix[i, j];
                    k++;
                }
                e++;
            }
            return output;
        }
        private static double Determinant(double[,] matrix)
        {
            if (matrix.Length == 4)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            double sign = 1, ansver = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double[,] minor = Minor(matrix, i, i);
                ansver += sign * matrix[0, i] * Determinant(minor);
                sign = -sign;
            }
            return ansver;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размер матрицы: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Random rand = new Random();
                Console.Write("Матрица: ");
                double[,] Matrix = new double[n, n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        Matrix[i, j] = rand.Next(1, 9);
                        Console.Write(Matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
                Console.Write("Определитель матрицы равен: " + Determinant(Matrix));
            }
            catch
            {
                Console.WriteLine("Ошибка: Вы введи не целое число");
            }
            
        }




    }
}
