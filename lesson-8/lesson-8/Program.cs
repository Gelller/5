using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 37;//размер массива
            int[] mas = new int[a];

            Random rnd = new Random();

            int colNumList = 10;//количество элементов в блоке
            int colList;//на какое количество блоков разобьется массив
            colList = a / colNumList;
            

            if (a % colNumList != 0)
                colList++;

            //лист листов
            List<int>[] ListList = new List<int>[colList];

            Console.WriteLine($"Не сортированный массив");
            //заполнение массива
            for (int i=0;i<mas.Length;i++)
            {       
                mas[i] = rnd.Next(0,100);
                Console.Write($"{mas[i]} ");
            }
     
            for (int i = 0; i < ListList.Count(); i++)
            {
                ListList[i] = new List<int>();
            }

            int j = 0;
            int num = 0;//номер листа
            //разбитие массива по листам
            for (int i = 0; i < mas.Length; i++)
            {
                //в лист кладется заданое в переменой colNumList элементов
                if (j != colNumList)
                {
                    ListList[num].Add(mas[i]);
                    j++;
                }
                else
                {
                    i--;
                    j = 0;
                    num++;
                }


            }

            //сортировка элементов листа 
            for (int i = 0; i < ListList.Count(); i++)
            {
                ListList[i].Sort();
            }

            //в буфер идет наименьшее значение из первых элементов листов
            int buffer = 0;
            //для удаление элемента из листа когда он записывается в массив
            int numElement = 0;
            //номер листа в листе листов
            int listNum = 0;


            for (int i = 0; i < mas.Length; i++)
            {     
                buffer = 0;
                numElement = 0;

                //проверка наличия в листе элементов
                while(ListList[listNum].Count == 0)
                {
                    numElement++;
                    listNum++;
                    
                }
                buffer = ListList[listNum][0];
                listNum = 0;


                while (listNum < ListList.Count())
                {
                    //проверка листа на наличие элементов, если true следующий лист 
                    if (ListList[listNum].Count == 0)
                        listNum++;

                    else
                    {
                          if (buffer > ListList[listNum][0])
                          {
                              buffer = ListList[listNum][0];
                              numElement = listNum;
                              listNum++;
                          }
                          else
                              listNum++;

                    }

                    //после проверки всех листов запись в массив
                        if (listNum == ListList.Count())
                        {
                            mas[i] = buffer;
                            //удаление записаного элемента из листа
                            ListList[numElement].Remove(buffer);                      
                        }
                    
                }
                listNum = 0;

                   
            }

            Console.WriteLine();

            Console.WriteLine($"Сортированный массив");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }

            
            Console.ReadLine();
        }
    }
}
