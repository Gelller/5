using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5
{
    class Tree
    {
        public Node StartNode;




        public Node DFSseach(int num)
        {
            Stack<Node> numbers = new Stack<Node>();
            Node start = StartNode;
            int i = 0;
            Node buffer = null;
            numbers.Push(start);

            while (numbers.Count != 0)
            {

                i++;
                buffer = numbers.Pop();
                Console.WriteLine($"Шаг {i} = {buffer.Data}");
                if (buffer.Data == num)
                    return buffer;


                if (buffer.Right != null)
                    numbers.Push(buffer.Right);
                if (buffer.Left != null)
                    numbers.Push(buffer.Left);

            }

            return null;
        }

        public Node BFSseach(int num)
        {
            Queue<Node> numbers = new Queue<Node>();
            Node start = StartNode;
            int i = 0;
            Node buffer = null;
            numbers.Enqueue(start);

            while (numbers.Count != 0)
            {

                i++;
                buffer = numbers.Dequeue();
                Console.WriteLine($"Шаг {i} = {buffer.Data}");
                if (buffer.Data == num)
                    return buffer;


                if (buffer.Right != null)
                    numbers.Enqueue(buffer.Right);
                if (buffer.Left != null)
                    numbers.Enqueue(buffer.Left);

            }

            return null;
        }

        //для вывода в консоль дерева
        public void PreOrderTravers(Node root, int x, int y)
        {


            if (root != null)
            {

                Console.SetCursorPosition(x, y);
                Console.WriteLine($"({root.Data})");


                y++;


                if (root.Parent == null)
                {

                    Console.SetCursorPosition(x - 10, y);
                    Console.WriteLine(@"_________/");
                    Console.SetCursorPosition(x + 4, y);
                    Console.Write(@"\________");
                }

                int lf = x - 10;//смещение элементов относительно центрального
                int rh = x + 10;

                if (root.Left != null && root.Parent != null)
                {
                    Console.SetCursorPosition(x - 4, y);
                    Console.WriteLine(@"___/");
                    lf = x - 4;

                }
                if (root.Right != null && root.Parent != null)
                {
                    Console.SetCursorPosition(x + 4, y);
                    Console.Write(@"\__");
                    rh = x + 4;

                }

                y++;
                if (root.Left != null || root.Right != null)
                {

                    PreOrderTravers(root.Left, lf, y);
                    PreOrderTravers(root.Right, rh, y);

                }

            }


        }

        public Node GetFreeNode(int value, Node parent)
        {
            var newNode = new Node
            {
                Data = value,
                Parent = parent
            };
            return newNode;
        }



        public Node Insert(int value)
        {
            Node tmp = null;
            Node head = StartNode;
            if (head == null)
            {

                head = GetFreeNode(value, null);
                StartNode = head;
                return head;
            }

            tmp = head;
            while (tmp != null)
            {
                if (value > tmp.Data)
                {
                    if (tmp.Right != null)
                    {
                        tmp = tmp.Right;
                        continue;
                    }
                    else
                    {
                        tmp.Right = GetFreeNode(value, tmp);
                        return head;
                    }
                }
                else if (value < tmp.Data)
                {
                    if (tmp.Left != null)
                    {
                        tmp = tmp.Left;
                        continue;
                    }
                    else
                    {
                        tmp.Left = GetFreeNode(value, tmp);
                        return head;
                    }
                }
                else
                {
                    throw new Exception("Wrong tree state");                  // Дерево построено неправильно
                }
            }
            return head;
        }



    }
}
