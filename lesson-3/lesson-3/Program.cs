using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace lesson_3
{
    class Program
    {


        //public class PointClass
        //{
        //    public float X=8;
        //    public float Y=9;
        //}

        //public struct PointStruct
        //{
        //    public int X;
        //    public int Y;
        //}


        static void Main(string[] args)
        {


         //   var point = new PointStruct { X = 8, Y = 9 };


            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

          
        }



        public class BenchmarClass
        {

           
                public int SumValueType(int value)
                {
                    return 9 + value;
                }

                public int SumRefType(object value)
                {
                    return 9 + (int)value;
                }

                [Benchmark]
                public void TestSum()
                {
                    SumValueType(99);
                }

                [Benchmark]
                public void TestSumBoxing()
                {
                    object x = 99;
                    SumRefType(x);
                }
            





            //   //[Benchmark]
            //   public static float PointDistanceFloatClass(PointClass pointOne, PointClass pointTwo)
            //   {
            //       float x = pointOne.X - pointTwo.X;
            //       float y = pointOne.Y - pointTwo.Y;
            //       return (float)Math.Sqrt((x * x) + (y * y));


            //   }

            ////  [Benchmark]
            //   public static float PointDistanceFloatStruct(PointStruct pointOne, PointStruct pointTwo)
            //   {
            //       float x = pointOne.X - pointTwo.X;
            //       float y = pointOne.Y - pointTwo.Y;
            //       return (float)Math.Sqrt((x * x) + (y * y));

            //   }

            //  // [Benchmark]
            //   public static double PointDistanceDoubleStruct(PointStruct pointOne, PointStruct pointTwo)
            //   {
            //       double x = pointOne.X - pointTwo.X;
            //       double y = pointOne.Y - pointTwo.Y;
            //       return Math.Sqrt((x * x) + (y * y));

            //   }

            // //  [Benchmark]
            //   public static double PointDistanceDoubleStruct2(PointStruct pointOne, PointStruct pointTwo)
            //   {
            //       double x = pointOne.X - pointTwo.X;
            //       double y = pointOne.Y - pointTwo.Y;
            //       return (x * x) + (y * y);
            //   }


        }



    }
}
