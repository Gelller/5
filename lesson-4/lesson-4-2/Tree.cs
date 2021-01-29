using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lesson_4_2
{
    class Tree
    {
        public Node StartNode=null;

        //удаление выбраного элемента
        public void Delete(int num)
        {

            var delete = seach(num);
            if (delete != null)
            {
                var node = delete.Parent;

                if (node.Left != null && node.Left.Data == num)
                    node.Left = null;
                if (node.Right != null && node.Right.Data == num)
                    node.Right = null;

                //для добавления элементов на которые указывал удаляемый
                ReturnBack(StartNode, delete, num);
            }

        }


        public void ReturnBack(Node start,Node root,int num)
        {

            if (root != null)
            {
                if(root.Data!=num)
                    Insert(root.Data);
              

                if (root.Left != null || root.Right != null)
                {
                    ReturnBack(start,root.Left, num);
                    ReturnBack(start,root.Right, num);

                }

            }


        }



        public Node seach (int num)
        {

            Node start = StartNode;

            while (start.Data != num)
            {

                while (start.Data < num)
                {
                    if (start.Right != null)
                        start = start.Right;
                    else
                        break;
                    
                }

                while (start.Data > num)
                {
                    if (start.Left != null)
                        start = start.Left;
                    else
                        break;

                    
                }


                //условия выхода из while
                if (start.Left == null || start.Right == null)
                {
                    if (start.Right != null && start.Right.Data == num)
                    {
                        start = start.Right;
                        break;
                     }
                    if (start.Left != null && start.Left.Data == num)
                    {
                        start = start.Left;
                        break;
                    }
                    break;
                }
            }

            if (start.Data == num)
                return start;
            else
                return null;
            
        }

        //для вывода в консоль дерева
        public void PreOrderTravers(Node root,int x,int y)
        {
            
            
            if (root != null)
            {
                
                    Console.SetCursorPosition(x,y);
                    Console.WriteLine($"({root.Data})");
                

                y++;
            

                if (root.Parent == null)
                {

                    Console.SetCursorPosition(x - 10, y);
                    Console.WriteLine(@"_________/");
                    Console.SetCursorPosition(x + 4, y);
                    Console.Write(@"\________");
                }

                int lf = x-10;//смещение элементов относительно центрального
                int rh = x + 10;

                if (root.Left != null && root.Parent != null)
                {
                    Console.SetCursorPosition(x-4, y);
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
                if (root.Left != null|| root.Right != null)
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
