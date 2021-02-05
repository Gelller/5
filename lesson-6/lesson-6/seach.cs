using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{
    class seach
    {
        public Node BFSseach(Node start, int num)
        {
            Queue<Node> numbers = new Queue<Node>();
            int i = 0;
            Node buffer = null;
            numbers.Enqueue(start);

            while (numbers.Count != 0)
            {

                i++;
                buffer = numbers.Dequeue();               

                Console.WriteLine($"Шаг {i} = {buffer.Value}");
                if (buffer.Value == num)
                    return buffer;
                else
                    buffer.Status=1;

                if (buffer.Edges != null)
                    foreach (var j in buffer.Edges)
                    {
                        //чтобы два раза не проверять один и тот же граф
                        if(j.Node.Status!=1)
                        numbers.Enqueue(j.Node);
                        j.Node.Status = 1;
                    }
               

            }

            return null;
        }

        public Node DFSseach(Node start, int num)
        {
            Stack<Node> numbers = new Stack<Node>();
            int i = 0;
            Node buffer = null;
            numbers.Push(start);

            while (numbers.Count != 0)
            {

                i++;
                buffer = numbers.Pop();
                Console.WriteLine($"Шаг {i} = {buffer.Value}");
                if (buffer.Value == num)
                    return buffer;
                else
                    buffer.Status = 2;


                if (buffer.Edges != null)
                    foreach (var j in buffer.Edges)
                    {
                        //после первого обхода статус не сбрасывается, возможно стоило добавить метод по сбросу статуса
                        if (j.Node.Status != 2)
                            numbers.Push(j.Node);
                        j.Node.Status = 2;
                    }

            }

            return null;
        }
    }
}
