using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_3_1
{
    class Program
    {
        static int StringNumbers(int number)
        {
            int finalNum = 0;

            if (number == 0)
                return finalNum = 0; ;

            if (number == 1)
                return finalNum = 1;

            return StringNumbers(number - 1) + StringNumbers(number - 2);

        }

        static void Main(string[] args)
        {


            Console.WriteLine("Введите значение");
            string number = Console.ReadLine();
            Console.WriteLine();

            bool isNum = int.TryParse(number, out int m);

            if (isNum)
            {
                int numberInt = Convert.ToInt32(number);

                while (0 < numberInt)
                {
                    Console.WriteLine(StringNumbers(numberInt));
                    numberInt--;
                }

            }
            Console.ReadLine();
        }
    }
}