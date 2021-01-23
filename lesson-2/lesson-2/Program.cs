using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();

            linkedList.AddNode(66);
            linkedList.AddNode(77);
            linkedList.AddNode(78);
            linkedList.AddNode(79);
            linkedList.AddNode(80);


            linkedList.Print();


            Console.WriteLine("Выберите после какого элемента добавить новый (выбор по значению элемента)");
            string std = Console.ReadLine();

            linkedList.AddNodeAfter(Convert.ToInt32(std));

            linkedList.Print();

            Console.WriteLine("Выберите элемент для удаления");
            std = Console.ReadLine();


            var del = linkedList.RemoveNode(Convert.ToInt32(std));

            if (del != null)
                Console.WriteLine($"Удален {del.Value}");       
            else
                Console.WriteLine("Не удален");



            Console.WriteLine("Выберите элемент для поиска");
            std = Console.ReadLine();

            var find = linkedList.FindNode(Convert.ToInt32(std));

            if (find!=null)
                Console.WriteLine($"Найден {find.Value}");
            else
                Console.WriteLine("Не найден");



            Console.WriteLine($"Элементов {linkedList.GetCount()}");

            linkedList.Print();
            Console.ReadLine();
        }
    }
}
