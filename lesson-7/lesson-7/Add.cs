using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7
{
    class Add
    {

        public void AddObstacle(ref int[,] mas)
        {
            Console.WriteLine("Введите координаты препятствий");
            Console.Write("X=");
            string x = Console.ReadLine();
            Console.Write("Y=");
            string y = Console.ReadLine();
            bool isNumX = int.TryParse(x, out int m);
            bool isNumY = int.TryParse(y, out int n);
            if (isNumX && isNumY && Convert.ToInt32(x) < mas.GetLength(0)-1 && Convert.ToInt32(y) < mas.GetLength(1)-1)
            {

                mas[Convert.ToInt32(x), Convert.ToInt32(y)] = 0;
            }
            else if (Convert.ToInt32(x) == mas.GetLength(0)-1 && Convert.ToInt32(y) == mas.GetLength(1)-1)
                Console.WriteLine("Не может быть правым нижним углом");
            else
                Console.WriteLine("Некорректный ввод данных");
        }
    }
}
