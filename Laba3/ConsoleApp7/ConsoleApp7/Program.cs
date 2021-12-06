using System;

namespace ConsoleApp7
{
    class Program
    {
        static int Fibonachi(int n)
        {
            if (n == 0 | n == 1)
            {
               return n;
            }
            else
            {
               return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите номер n-ого члена ряда Фибоначчи: " + " ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ответ: " + Fibonachi(n));
            }
            catch
            {
                Console.WriteLine("Ошибка: Вы ввели не целое число!");
            }
            
        }
    }
}
