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

            

           
            var startnode = Tree.Insert(null, 16);
            Tree.Insert(startnode, 2);
            Tree.Insert(startnode, 37);
            Tree.Insert(startnode, 41);
            Tree.Insert(startnode, 15);
            Tree.Insert(startnode, 57);
            Tree.Insert(startnode, 25);
            Tree.Insert(startnode, 35);
            Tree.Insert(startnode, 1);
            Tree.Insert(startnode, 7);
            Tree.Insert(startnode, 5);
            Tree.Insert(startnode, 9);
            Tree.Insert(startnode, 11);
            Tree.Insert(startnode, 10);
            Tree.Insert(startnode, 13);
            Tree.Insert(startnode, 14);
            Tree.Insert(startnode, 19);
            Tree.Insert(startnode, 22);


            Tree.PreOrderTravers(startnode, (Console.WindowWidth / 2), 0);

            Console.WriteLine("Введите число для добавления");
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            Tree.Insert(startnode, num);


            Tree.PreOrderTravers(startnode, (Console.WindowWidth / 2), 0);

          
            Console.WriteLine();

            Console.WriteLine("Введите число для поиска");
            str = Console.ReadLine();
            num = Convert.ToInt32(str);
            if (Tree.seach(startnode, num)!= null)
                Console.WriteLine("Найдено");
            else
                Console.WriteLine("Не найдено");


            Console.WriteLine("Введите число для удаления");
            str = Console.ReadLine();
            num = Convert.ToInt32(str);
            Tree.delete(startnode, num);

            Console.Clear();
            Tree.PreOrderTravers(startnode, (Console.WindowWidth / 2), 0);



            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
