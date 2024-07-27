using Demo.Binging;
using Demo.Polymorphism;
using System.Security.Cryptography.X509Certificates;

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

        #region Binding
        public static void ProcessEmployee (Employee employee)
        {
            employee.GetEmployeeType();
            employee.GetEmployeeData();
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

            #region Binding
            //TypeA RefBase;
            //RefBase = new TypeB(15,30);
            //RefBase.fun01();
            //RefBase.fun02();
            #endregion

            #region Not Binding
            //TypeB t1 = new TypeA(1);
            //TypeB t1 = (TypeB)new TypeA(1);
            //Console.WriteLine(t1.A);
            //Console.WriteLine(t1.B);

            //TypeA t1 = new TypeB(1,2);
            //TypeB t2 = (TypeB) t1;
            //Console.WriteLine(t2.A);
            //Console.WriteLine(t2.B);
            #endregion

            #region Binding 
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1,"Fatma",23,5000);
            //ProcessEmployee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Age = 23,
            //    Name = "Ahmed",
            //    CountofHours = 12,
            //    HourRate = 2.2M
            //};

            //ProcessEmployee(partTimeEmployee);

            #endregion

            #region 
            #endregion
        }
    }
}
