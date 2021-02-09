using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7
{
    class Program
    {


       
        static void Main(string[] args)
        {
            var Print = new Print();
            var Add = new Add();
            int a = 10;//размер массива
            int b = 10;
            int i, j;
            int[,] mas = new int[a, b];
            bool add = true;

         
            //заполнения массива 1
            for (i = 0; i < mas.GetLength(0); i++)
            {

                for (j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j]=1;
                }
            }

            Console.WriteLine("Добавить препятствие Y-да, N-нет");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                Add.AddObstacle(ref mas);


                while (add)
                {
                    Console.WriteLine("Добавить ещё?");
                    answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y")
                        Add.AddObstacle(ref mas);
                    else
                        add = false;
                }

            }

            Console.Clear();
            Print.PrintConsole(a, b, ref mas);


            for (i = 1; i < b; i++)
            {
                for (j = 1; j < b; j++)
                {

                    if (mas[i, j] == 1)
                        mas[i, j] = mas[i, j - 1] + mas[i - 1, j];

                    else if (mas[i, j] == 0)
                        mas[i, j] = 0;
                }
            }

            Console.WriteLine();

            Print.PrintConsole(a, b, ref mas);

            Console.WriteLine($"Количество путей из верхней левой клетки в правую нижнюю {mas[mas.GetLength(0)-1,mas.GetLength(1)-1]}") ;
            Console.ReadLine();
        }
    }
}
