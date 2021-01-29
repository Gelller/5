using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tree = new Tree();

            Tree.Insert(16);
            Tree.Insert(2);
            Tree.Insert(37);
            Tree.Insert(41);
            Tree.Insert(15);
            Tree.Insert(57);
            Tree.Insert(25);
            Tree.Insert(35);
            Tree.Insert(1);
            Tree.Insert(7);
            Tree.Insert(5);
            Tree.Insert(9);
            Tree.Insert(11);
            Tree.Insert(10);
            Tree.Insert(13);
            Tree.Insert(14);
            Tree.Insert(19);
            Tree.Insert(22);

            Tree.PreOrderTravers(Tree.StartNode, (Console.WindowWidth / 2), 0);


            Console.WriteLine("DFS поиск, введите число для поиска");
            string str = Console.ReadLine();
            bool isNum = int.TryParse(str, out int n);
            if (isNum)
            {
                int num = Convert.ToInt32(str);

                if (Tree.DFSseach(num) != null)
                    Console.WriteLine($"Найден {num}");
                else
                    Console.WriteLine("Не найдено");
            }
            else
                Console.WriteLine("Некорректный ввод данных");

            Console.ReadLine();

            //////////////////////////////////////////////////////////////////
            
            Console.Clear();
            Tree.PreOrderTravers(Tree.StartNode, (Console.WindowWidth / 2), 0);

            Console.WriteLine("BFS поиск, введите число для поиска");
            str = Console.ReadLine();
            isNum = int.TryParse(str, out int m);
            if (isNum)
            {
                int num = Convert.ToInt32(str);

                if (Tree.BFSseach(num) != null)
                    Console.WriteLine($"Найден {num}");
                else
                    Console.WriteLine("Не найдено");
            }
            else
                Console.WriteLine("Некорректный ввод данных");



            Console.ReadLine();

        }
    }
    
}
