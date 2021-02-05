using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6
{
    class ConsoleOut
    {
        //получилось очень громоздко, красиво работает только с данными графами
        public void Out(Node node)
        {
            char down = '|';
            char left = '/';
            char right = '\u005c';


            int x = Console.WindowWidth / 2;
            int y = 0;

            Console.SetCursorPosition(x, y);
            Console.WriteLine($"({ node.Value})");
            y++;

            Console.SetCursorPosition(x, y);
            Console.Write(left);
            Console.SetCursorPosition(x + 3, y);
            Console.Write(right);

            y++;
            Console.SetCursorPosition(x - 1, y);
            Console.Write(left);
            Console.SetCursorPosition(x + 4, y);
            Console.Write(right);

            y++;
            Console.SetCursorPosition(x - 3, y);
            Console.WriteLine($"({node.Edges[0].Node.Value})");


            Console.SetCursorPosition(x + 4, y);
            Console.WriteLine($"({node.Edges[1].Node.Value})");


            y++;
            Console.SetCursorPosition(x - 2, y);
            Console.Write(down);
            Console.Write(right);

            Console.SetCursorPosition(x + 4, y);
            Console.Write(left);
            Console.Write(down);

            y++;
            Console.SetCursorPosition(x, y);
            Console.Write(right);

            Console.SetCursorPosition(x - 2, y);
            Console.Write(down);

            Console.SetCursorPosition(x + 3, y);
            Console.Write(left);

            Console.SetCursorPosition(x + 5, y);
            Console.Write(down);

            y++;
            Console.SetCursorPosition(x + 1, y);
            Console.WriteLine($"({node.Edges[1].Node.Edges[0].Node.Value})");


            Console.SetCursorPosition(x - 2, y);
            Console.Write(down);

            Console.SetCursorPosition(x + 5, y);
            Console.Write(down);

            y++;
            Console.SetCursorPosition(x - 2, y);
            Console.Write(down);

            Console.SetCursorPosition(x + 4, y);
            Console.Write(right);
            Console.Write(down);


            y++;

            Console.SetCursorPosition(x - 3, y);
            Console.WriteLine($"({node.Edges[0].Node.Edges[1].Node.Value})--->({node.Edges[1].Node.Edges[1].Node.Value})");

        }
    }
}
