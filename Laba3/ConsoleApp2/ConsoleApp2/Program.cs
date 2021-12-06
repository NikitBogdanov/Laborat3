using System;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] mass = new int[7, 7];
            Console.WriteLine("Изначальный массив: ");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    mass[i, j] = rand.Next(10, 99);
                    Console.Write(mass[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Повёрнутый массив: ");
            for (int i = 0; i < Convert.ToDouble(7 / 2); i++)
            {
                Console.WriteLine();
                for (int j = i; j < 7 - i - 1; j++)
                {
                    int sign = mass[i, j];
                    mass[i, j] = mass[7 - j - 1, i];
                    mass[7 - j - 1, i] = mass[7 - i - 1, 7 - j - 1];
                    mass[7 - i - 1, 7 - j - 1] = mass[j, 7 - i - 1];
                    mass[j, 7 - i - 1] = sign;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
            }
        }
    }
}
