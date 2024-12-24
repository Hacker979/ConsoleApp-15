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
            for (int x = 1; x <= 8; x++)
            {
                int num = pon.Next(-30,30);
                Console.WriteLine($"{x} число = {num} {(num < 0 ? "Отрицательное" : "Положительное")}, {(num % 2==0 ? "четное" : "нечетное")}");
                z = num >= 0 ? a++ : a+0;
                
            }
            Console.WriteLine(z);
        }

        /// <summary>
        /// Задача 7. Генерируется 8 случайных целых чисел в интервале (–30, 30).
        /// Выводятся эти числа и сообщения: отрицательное – положительное, четное – нечетное (for, if).
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Rand();

            Console.ReadLine();
        }
    }
}
