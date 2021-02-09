using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7
{
    class Print
    {
        public void PrintConsole(int a, int b, ref int[,] mas)
        {

            for (int i = 0; i < mas.GetLength(0); i++)
            {

                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
