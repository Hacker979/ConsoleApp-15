using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_15
{
    class Program
    {
        static void print()
        {
            for (int x = 2; x <= 20; x++)
            {
                Console.WriteLine($"{x}штук = {x*20.4} руб");
            }
        }

        /// <summary>
        /// Задача 2. Одна штука некоторого товара стоит 20,4 руб.
        /// Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            print();

            Console.ReadLine();
        }
    }
}
