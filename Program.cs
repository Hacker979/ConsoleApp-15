using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_15
{
    class Program
    {
        static void Rand()
        {
            Random pon = new Random();
            int a = 0;
            int z = 0;
            for (int x = 1; x <= 15; x++)
            {
                int num = pon.Next(-20,30);
                Console.WriteLine($"{x} число = {num}");
                z = num >= 0 ? a++ : a+0;
                
            }
            Console.WriteLine(z);
        }

        /// <summary>
        /// Задача 5. Генерируются 15 случайных целых чисел в интервале (-20, 30). Вывести эти числа и подсчитать количество положительных чисел.
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Rand();

            Console.ReadLine();
        }
    }
}
