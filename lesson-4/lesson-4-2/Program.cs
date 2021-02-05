using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_2
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

            Console.WriteLine("Введите число для добавления");
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            Tree.Insert(num);


            Tree.PreOrderTravers(Tree.StartNode, (Console.WindowWidth / 2), 0);


            Console.WriteLine();

            Console.WriteLine("Введите число для поиска");
            str = Console.ReadLine();
            num = Convert.ToInt32(str);
            if (Tree.seach(num) != null)
                Console.WriteLine("Найдено");
            else
                Console.WriteLine("Не найдено");


            Console.WriteLine("Введите число для удаления");
            str = Console.ReadLine();
            num = Convert.ToInt32(str);
            Tree.Delete(num);

            Console.Clear();
            Tree.PreOrderTravers(Tree.StartNode, (Console.WindowWidth / 2), 0);



            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
