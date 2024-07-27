﻿using Demo.Polymorphism;

namespace Demo
{
    internal class Program
    {
        #region Overloading
        public static int sum (int x,int y)
        { 
            return x + y;
        }
        public static double sum(double x, double y)
        {
            return x + y;
        }

        public static int sum(int x, int y , int z)
        {
            return x + y + z;
        }

        public static double sum(int x, double y)
        {
            return x + y;
        }

        public static double sum(double x, int y)
        {
            return x + y;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Polymorphism [overloading]
            //int Result = sum(1, 2, 3);
            //Console.WriteLine($"Result = {Result}");

            //Console.WriteLine("*******************");

            //Result = sum(1, 2);
            //Console.WriteLine($"Result = {Result}");

            //Console.WriteLine("*******************");

            //double Result02 = sum(1.2, 2.6);
            //Console.WriteLine($"Result = {Result02}");

            //Console.WriteLine("*******************");

            //Result02 = sum(1.2, 2);
            //Console.WriteLine($"Result = {Result02}");

            //Console.WriteLine("*******************");

            //Result02 = sum(1, 2.5);
            //Console.WriteLine($"Result = {Result02}");

            //Console.WriteLine("*******************");
            #endregion

            #region Polymorphism [overriding]
            //TypeA t1 = new TypeA (10) ;
            //t1.fun01();
            //t1.fun02();
            //Console.WriteLine("************");
            //TypeB t2 = new TypeB(10,20);
            //t2.fun01();
            //t2.fun02();
            #endregion


        }
    }
}
