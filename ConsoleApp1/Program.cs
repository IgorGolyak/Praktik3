using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2.
            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (-2.4 < 5.7)
            {
                y = (Math.Pow(Math.Sin(x), 2));

            }
            else
            {
                Console.WriteLine("В противном случае 4");
            }
            Console.WriteLine("Ответ:" + y);
            Console.ReadKey();
        }
    }
}
