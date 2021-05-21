using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_Работа__3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            Console.WriteLine("Введете число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введете число a");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 100;
            int a1 = i / 100;
            int b1 = i / 10;
            if (a > b)
            {
                Console.WriteLine("Первя цифра больше");
            }
            else
            {
                Console.WriteLine("Вторая цифра больше");
            }
            Console.ReadKey();



        }

    }
}
