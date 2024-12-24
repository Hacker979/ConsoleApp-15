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
            int a = 0;
            for (int x = 10; x <= 99; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                    a++;
                } 
            }
            Console.WriteLine(a);
        }

        /// <summary>
        /// Задача 3. Вывести четные двузначные числа и подсчитать их количество.
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            print();

            Console.ReadLine();
        }
    }
}
