using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{
    class Program
    {  

        static void Main(string[] args)
        {
           
           //корень 77
            var node = new Node()
            {
                Value = 77,
                Edges = new List<Edge>()

            };

            // от корня ссылки на 7 и 10
            node.Edges.Add(new Edge() { Node = new Node { Value = 7, Edges = new List<Edge>() }, Weight = 8 });
            node.Edges.Add(new Edge() { Node = new Node { Value = 10, Edges = new List<Edge>() }, Weight = 84 });

            var BufNode = node.Edges[0];
            var BufNode2 = node.Edges[1];

            //ссылка от 7 до 1
            BufNode.Node.Edges.Add(new Edge() { Node = new Node { Value = 1 , Edges = new List<Edge>() }, Weight = 18 });
            //ссылка от 7 до 9
            BufNode.Node.Edges.Add(new Edge() { Node = new Node { Value = 9 , Edges = new List<Edge>() }, Weight = 28 });

            //ссылка от 10 до 1
            BufNode2.Node.Edges.Add(new Edge() { Node = BufNode.Node.Edges[0].Node, Weight = 28 });
            //ссылка от 10 до 3
            BufNode2.Node.Edges.Add(new Edge() { Node = new Node { Value = 3 }, Weight = 78 });


            BufNode = node.Edges[0].Node.Edges[0];
            BufNode2 = node.Edges[1].Node.Edges[1];

            //ссылка от 1 до 3
            BufNode.Node.Edges.Add(new Edge() { Node = BufNode2.Node, Weight = 28 });

            BufNode = BufNode.Node.Edges[0];
            BufNode2 = node.Edges[0].Node.Edges[1];
            //ссылка от 9 до 3
            BufNode2.Node.Edges.Add(new Edge() { Node = BufNode.Node, Weight = 28 });



            var ConsoleOut = new ConsoleOut();

            ConsoleOut.Out(node);
           

            var seach = new seach();
            Console.WriteLine("BFS поиск, введите число для поиска");
            string str = Console.ReadLine();
            bool isNum = int.TryParse(str, out int m);
            if (isNum)
            {
                int num = Convert.ToInt32(str);

                if (seach.BFSseach(node, num) != null)
                    Console.WriteLine($"Найден {num}");
                else
                    Console.WriteLine("Не найдено");
            }
            else
                Console.WriteLine("Некорректный ввод данных");


            Console.WriteLine("DFS поиск, введите число для поиска");
            str = Console.ReadLine();
            isNum = int.TryParse(str, out int n);
            if (isNum)
            {
                int num = Convert.ToInt32(str);

                if (seach.DFSseach(node, num) != null)
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
