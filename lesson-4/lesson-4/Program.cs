using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace lesson_4
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



    public partial class Program
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

      //  public HashSet<User> hashSet;
        //public static HashSet<User> rro()
        //{
        //    var hashSet = new HashSet<User>();
        //    return hashSet;
        //}

        static void Main(string[] args)
        {
            
                int mas = 10; //размер массива строк
                int lineLength = 4;//длина создаваемых строк

                string[] User1 = new string[mas];

          //  var hashSet = rro();
            var hashSet = new HashSet<User>();

                for (int i = 0; i < mas; i++)
                {


                    //заполнение первого элемента массива
                    if (i==0)
                    User1[i] = RandomString(lineLength);

                    //заполнение всех остальных с проверкой на повторение
                    if (i > 0)
                    User1[i] = СheckRandomString(ref User1[i - 1], RandomString(lineLength));


                    var user = new User() { FirstName = User1[i] };
                    hashSet.Add(user);

                }
                Console.WriteLine("Массив строк создан");




              var searchUsser = new User() { FirstName = User1[4] };

                if (hashSet.Contains(searchUsser))
                    Console.WriteLine("Найден по HashSet");
                else
                    Console.WriteLine("Не найден по HashSet");

                bool seach = false;
                for (int i = 0; i < mas; i++)
                {

                    if (User1[i] == "ee")
                        seach = true;
                    else
                        seach = false;


                }

                if(seach)
                    Console.WriteLine("Найден по поиску значения в массиве");
                    else
                    Console.WriteLine("Не найден по поиску значения в массиве");

            
            
          //  BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadLine();
        }

        //public class BenchmarClass
        //{


        //    public static int mas = 10000;
        //    public static string[] User1 = new string[mas];
        //    //  public string hashSet = new HashSet<User>();

        //    public static HashSet<User> hashSet;
        //    // {
        //    //    var hashSet = new HashSet<User>();
        //    //    return hashSet;
        //    // }


        //    public void a()
        //    {
        //        // int mas = 10; //размер массива строк
        //        int lineLength = 4;//длина создаваемых строк

        //        //string[] User1 = new string[mas];
        //       // var hashSet1 = hashSet;

        //        // var hashSet = rro();

        //        for (int i = 0; i < mas; i++)
        //        {


        //            //заполнение первого элемента массива
        //            if (i == 0)
        //                User1[i] = RandomString(lineLength);

        //            //заполнение всех остальных с проверкой на повторение
        //            if (i > 0)
        //                User1[i] = СheckRandomString(ref User1[i - 1], RandomString(lineLength));


        //            var user = new User() { FirstName = User1[i] };
        //            hashSet.Add(user);




        //        }
        //        Console.WriteLine("Массив строк создан");

        //    }




        //    //[Benchmark]
        //    //public void testHashSet()
        //    //{
        //    //    //string s = "dd";
        //    //    //  var hashSet = rro();
        //    //    var searchUsser = new User() { FirstName = User1[500] };

        //    //    if (hashSet.Contains(searchUsser))
        //    //    { }
        //    //    //   Console.WriteLine("Найден по HashSet");
        //    //    //  else
        //    //    //  Console.WriteLine("Не найден по HashSet");
        //    //    //   hashSet.Contains(searchUsser);
        //    //}



        //    [Benchmark]
        //    public void testMas()
        //    {



        //        for (int i = 0; i < mas; i++)
        //        {

        //            if (User1[i] == User1[500])
        //                User1[i] = "";




        //        }

        //    }



        //}


    }

}

