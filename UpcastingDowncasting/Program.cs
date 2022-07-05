using System;
using UpcastingDowncasting.Models;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Params
            //int[] arr = { 1, 2, 3, 4, 5, };
            //GetElements(1, 2, 3, 4, 5, 6, 7, 8, 9);
            #endregion
            #region NullAble



            //CheckRole(0);
            //Test test = new Test();
            //Console.WriteLine(test.Number);

            //string name = null;
            //int? age = 60;

            ////var result = age == null ? 55 : 60;
            //var result = age ?? 60;



            //Console.WriteLine(result);
            #endregion
            #region struct
            //Test2 test2 = new Test2(5);
            #endregion

            byte m = 5;
            int n = m;

            Eagle eagle1 = new Eagle();
            Eagle eagle3 = new Eagle();
            Animal eagle2 = eagle1;
            Shark shark1 = new Shark();
            Animal shark2 = new Shark();

            Animal[] animals = { eagle1, eagle2, eagle3, shark1, shark2 };

           foreach (var item in animals)
            {
                item.Eat();
            }
         


        }

        #region Params
        public static void GetElements(params int[] nums)
        {
            
            
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            
        }
        #endregion
        #region enum
        //static void CheckRole(int roleId)
        //{
        //    switch (roleId)
        //    {
        //        case (int)Role.ElaAdmin:
        //            Console.WriteLine("ElaAdmin");
        //            break;

        //        case (int)Role.SuperAdmin:
        //            Console.WriteLine("SuperAdmin");
        //            break;

        //        case (int)Role.Member:
        //            Console.WriteLine("Member");
        //            break;

        //        default:
        //            Console.WriteLine("404");
        //            break;
        //    }

        //}
        #endregion


    }
    #region enum
    public enum Role
    {
        SuperAdmin,
        ElaAdmin,
        Member,
    }
    #endregion

    #region NullAble
    //class Test
    //{
    //    public int? Number { get; set; }
    //    public string Word { get; set; }
    //}
    #endregion
    #region Struct
    public class Test2
    {
        public int MyProperty { get; set; } = 66;

        public Test2(int b)
        {
            Console.WriteLine("dolu");
        }
        public Test2()
        {
            Console.WriteLine("bosh");
        }
    }

    struct Test1
    {
        public int Num { get; set; }

        public Test1(string name)
        {
            Num = 60;
            Console.WriteLine(Num);
        }
    }
    
   struct Test3
    {

    }
    #endregion
}
