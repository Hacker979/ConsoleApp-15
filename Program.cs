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
            for (int x = 1; x <= 10; x++)
            {
                int num = pon.Next(-40,40);
                Console.WriteLine($"{x} число = {num}");
            }
        }

        /// <summary>
        /// Задача 4. Генерируются 10 случайных целых чисел в интервале (-40, 40). Вывести эти числа.
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Rand();

            Console.ReadLine();
        }
    }
}
