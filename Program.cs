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
            for (int x = 1; x <= 12; x++)
            {
                int num = pon.Next(-50,50);
                Console.WriteLine($"{x} число = {(num < 0 ? "Отрицательное" : "Положительное")}");
                z = num >= 0 ? a++ : a+0;
                
            }
            Console.WriteLine(z);
        }

        /// <summary>
        /// Задача 6. Генерируется 12 случайных целых чисел в интервале (-50,50). Вывести эти числа и сообщения: отрицательное-положительное.
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Rand();

            Console.ReadLine();
        }
    }
}
