using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        static void fun()
        {

            Console.WriteLine("Введите число");
            string num = Console.ReadLine();
            int d = 0, i = 2;

            if (i < (int.Parse(num)))
            {

                if ((int.Parse(num) % i == 0))
                    d++;
                else
                    i++;
            }

            if (d == 0)
                Console.WriteLine("Число простое");
            else
                Console.WriteLine("Число не простое");

            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            fun();

        }
    }
}
