using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размер массива: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество позиций, на которые будет двигаться массив: ");
                int k = int.Parse(Console.ReadLine());
                Random rand = new Random();
                int[] mass = new int[n];
                for (int i = 0; i < n; i++)
                {
                    mass[i] = rand.Next(1, 9);
                    Console.Write(mass[i] + " ");
                }
                Console.WriteLine();
                int[] ansver = new int[n];
                for (int i = 0; i < n; i++)
                {
                    ansver[i] = mass[(i + k) % mass.Length];
                    Console.Write(ansver[i]);
                }
            }
            catch
            {
                Console.WriteLine("Ошибка: Размер массива - только целое число!");
            }
        }
    }
}