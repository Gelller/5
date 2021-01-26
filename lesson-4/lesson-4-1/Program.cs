using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace lesson_4_1
{
    public class User
    {
        public string FirstName { get; set; }


        public override bool Equals(object obj)
        {
            var user = obj as User;

            if (user == null)
                return false;

            return FirstName == user.FirstName;
        }

        public override int GetHashCode()
        {
            int firtsNameHashCode = FirstName?.GetHashCode() ?? 0;

            return firtsNameHashCode;
        }

    }



    public class Program
    {

        //генератор случайной строки
        public static string RandomString(int length)
        {
            var result = new char[length];
            var r = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                do

                    result[i] = (char)r.Next(127);


                while (result[i] < '!');
            }

            return new string(result);
        }

        //проверка строки на совпадение
        public static string СheckRandomString(ref string mas, string std)
        {
            bool bl = true;
            string stringNew = "";

            while (bl)
            {
                if (mas == std)
                    std = RandomString(4);
                else
                    bl = false;
            }

            return stringNew = std;

        }

        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadLine();
        }


       


        public class BenchmarClass
        {


            public static int mas = 10000;//размер массива
            public static string[] masStr = new string[mas]; 
            public HashSet<User> hashSet;

          
           public BenchmarClass()
           {
                int lineLength = 4;//длина создаваемых строк

                var hashSetBuf = new HashSet<User>();

                for (int i = 0; i < mas; i++)
                {

                    //заполнение первого элемента массива
                    if (i == 0)
                        masStr[i] = RandomString(lineLength);

                    //заполнение всех остальных с проверкой на повторение
                    if (i > 0)
                        masStr[i] = СheckRandomString(ref masStr[i - 1], RandomString(lineLength));
                    
                    var UserString = new User() { FirstName = masStr[i] };
                    hashSetBuf.Add(UserString);



                }
                Console.WriteLine("Массив строк создан");
             
                hashSet = hashSetBuf;

             
           }

            [Benchmark]
            public void testHashSet()
            {

                var searchUsser = new User() { FirstName = masStr[500] };

                hashSet.Contains(searchUsser);

            }



            [Benchmark]
            public void testMas()
            {
                


                for (int i = 0; i < mas; i++)
                {

                    if (masStr[i] == masStr[500])
                        masStr[i] = "";

                }

            }



        }


    }
}
