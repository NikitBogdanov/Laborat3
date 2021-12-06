using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
           try
           {
                Console.WriteLine("Введите размер массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Random rand = new Random();
                int[] arrey = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arrey[i] = rand.Next(1, 100);
                    Console.Write(arrey[i] + " ");
                }
                if (n % 2 == 0)
                {
                    int left = 0;
                    int N = n / 2;
                    for (int i = 0; i < N; i++)
                    {
                        left += arrey[i];
                    }
                    int right = 0;
                    for (int i = N; i < n; i++)
                    {
                        right += arrey[i];
                    }
                    Console.WriteLine("Ответ: " + (left - right));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" В какую сторону добавить центральный элемент массива 'left' или 'right'? ");
                    string LoR = Console.ReadLine();
                    if (LoR == "left")
                    {
                        int left = 0;
                        int N = (int)(n / 2) + 1;
                        for (int i = 0; i < N; i++)
                        {
                            left += arrey[i];
                        }
                        int right = 0;
                        for (int i = N; i < n; i++)
                        {
                            right += arrey[i];
                        }
                        Console.WriteLine("Ответ: " + (left - right));
                    }
                    else if (LoR == "right")
                    {
                        int left = 0;
                        int N = (int)(n / 2);
                        for (int i = 0; i < N; i++)
                        {
                            left += arrey[i];
                        }
                        int right = 0;
                        for (int i = N; i < n; i++)
                        {
                            right += arrey[i];
                        }
                        Console.WriteLine("Ответ: " + (left - right));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Введите либо 'left' либо 'right'!");
                    }
                }
           }
            catch
            {
                Console.WriteLine("Ошибка: Вы ввели не целое число!");
            }
        }
    }
}
