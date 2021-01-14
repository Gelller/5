using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение");
            string number = Console.ReadLine();
            Console.WriteLine();

            bool isNum = int.TryParse(number, out int m);
            int sum = 0, perv = 1, sled = 1;
            if (isNum)
            {
                int numberInt = Convert.ToInt32(number);

                for (int i = 0; i < numberInt - 2; i++)
                {
                    sum = perv + sled;
                    Console.WriteLine(sum);
                    perv = sled;
                    sled = sum;
                }

            }

            Console.ReadLine();
        }
    }
}
