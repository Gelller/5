using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4
{
    public class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public override bool Equals(object obj)
        {
            var user = obj as User;

            if (user == null)
                return false;

            return FirstName == user.FirstName && SecondName == user.SecondName;
        }

        public override int GetHashCode()
        {
            int firtsNameHashCode = FirstName?.GetHashCode() ?? 0;
            int secondNameHashCode = SecondName?.GetHashCode() ?? 0;
            return firtsNameHashCode ^ secondNameHashCode;
        }

    }

    
    
    class Program
    {


        public static void RandomString(ref string[] mas)
        {
           
            char[] array = { 'a', '3', 's', 'w', 'w', '4', '=', 'a', 'a', 'w', '3' };
           // var result = new char[length];
           // var r = new Random().Next(1,5);

            //string [] a=new string[mas.Length]; 
                
                
            for (int i = 0; i < mas.Length; i++)
            {
                 var r = new Random().Next(1,10);
               mas[i]= array[r].ToString();
                   // a[i] = array[r].ToString(); 
               
            }
         //  string a="лл";
         //   return mas;

           
            
        }

        

        static void Main(string[] args)
        {
           
             string[] daysOfWeek = new string[4];
            string [] User1=new string[4];
            RandomString(ref daysOfWeek);
            for(int i=0;i<4;i++)
            {
                
                // var hashSet = new HashSet<User>();
                

                // var user = new User() { FirstName = RandomString(3), SecondName = RandomString(2) };
                // hashSet.Add(user);

                User1[i]=daysOfWeek[i];
              // Console.WriteLine(RandomString(1));

                 var searchUsser = new User() { FirstName = "Barbara", SecondName = "Santa" };

                 //Console.WriteLine($"contains user {hashSet.Contains(user)}, contains searchUsser {hashSet.Contains(searchUsser)} first name {user.FirstName} seconf name {user.SecondName}");

                 Console.WriteLine($"{i}={User1[i]}");
                //Console.ReadLine();
                
            }

           // Console.WriteLine()
           
            Console.ReadLine();
        }
    }

}
