using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    public class Node
	{
		public int Value { get; set; }
		public Node NextItem { get; set; }
		public Node PrevItem { get; set; }
	}
	public interface ILinkedList
	{

		int GetCount(); // возвращает количество элементов в списке
		void AddNode(int value);  // добавляет новый элемент списка
		void AddNodeAfter(int value); // добавляет новый элемент списка после определённого элемента
		//void RemoveNode(int index); // удаляет элемент по порядковому номеру
		Node RemoveNode(int node); // удаляет указанный элемент
		Node FindNode(int value); // ищет элемент по его значению
        void Print(); //выводит список элементов
    }


    public class LinkedList : ILinkedList
    {

        private int _count = 0;
        private Node _StartNode;
        private Node _EndNode;

        public void AddNode(int value)
        {
            if (_StartNode == null)
            {
                _StartNode = new Node { Value = value };
                _EndNode = _StartNode;

            }
            else
            {

                // ссылка у предыдущего на следующий
                _EndNode.NextItem = new Node { Value = value };

                // ссылка у следущего на предыдущий
                _EndNode.NextItem.PrevItem = _EndNode;

                //следующий становится последним элементом
                _EndNode = _EndNode.NextItem;

            }

            _count++;
        }

        public void AddNodeAfter (int value)
        {
           
            Console.WriteLine("Значение нового элемента");
            string std = Console.ReadLine();

            var currentNode = _StartNode;

            bool isNum = int.TryParse(std, out int n);

            if (isNum)
            {
                var newN = new Node { Value = Convert.ToInt32(std) };

                while (currentNode != null)
                {
                    //добавление элементов куда угодно кроме конца
                    if (currentNode.Value == value && currentNode != _EndNode)
                    {

                        currentNode.NextItem.PrevItem = newN;
                        newN.PrevItem = currentNode;
                        newN.NextItem = currentNode.NextItem;
                        newN.NextItem.PrevItem = newN;
                        currentNode.NextItem = newN;
                        _count++;
                    }
                    //добавление элемента в конец
                    if (currentNode.Value == value && currentNode == _EndNode)
                    {

                        currentNode.NextItem = newN;
                        newN.PrevItem = currentNode;
                        _EndNode = newN;
                        _count++;
                    }


                    currentNode = currentNode.NextItem;
                }

            }

        }

        public Node FindNode(int value)
        {
            var currentNode = _StartNode;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                    return currentNode;

                currentNode = currentNode.NextItem;
            }

            return null;
        }

        public int GetCount()
        {

            return _count;

        }


        public Node RemoveNode(int node)
        {
            var currentNode = _StartNode;

            while (currentNode.NextItem != null)
            {

                //для превого элемента
                if(currentNode==_StartNode && currentNode.Value == node)
                {
                   currentNode.NextItem.PrevItem = null;
                   _StartNode=currentNode.NextItem;  
                   _count--;
                   return currentNode;
                }

                //для всех кроме превого и последнего элемента
                if (currentNode.Value == node)
                {
                  
                    currentNode.PrevItem.NextItem = currentNode.NextItem;
                    currentNode.NextItem.PrevItem = currentNode.PrevItem;
                    _count--;
                    return currentNode;
                }

                
                currentNode = currentNode.NextItem;
            }
            //для последнего элемента элемента
                if(currentNode==_EndNode && currentNode.Value == node)
                {
                   currentNode.PrevItem.NextItem = null;
                   currentNode.PrevItem = _EndNode;  
                   _count--;
                   return currentNode;
                }


            return null;

        }

        public void Print()
        {
            int i = 1;
             var currentNode = _StartNode;

            while (currentNode!= null)
            {

                Console.WriteLine($"Элемент {i}= {currentNode.Value}");
                
                currentNode = currentNode.NextItem;
                i++;
            }
            
        }

    }

}
