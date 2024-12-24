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
            for (int x = 0; x <= 10; x++)
            {
                Console.Write("20 ");
            }
        }

        /// <summary>
        /// Задача 1. Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            print();

            Console.ReadLine();
        }
    }
}
