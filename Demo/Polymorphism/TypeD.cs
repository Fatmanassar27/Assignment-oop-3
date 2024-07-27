using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int a, int b, int c ,int d) : base(a, b , c)
        {
            D = d;
        }
        public new void fun01()
        {
            Console.WriteLine("I am Derived [Child of Grand Child]");
        }
        public new virtual void fun02()
        {
            Console.WriteLine($"Type D : A = {A}   B = {B}   C = {C}  D = {D}");
        }
    }
}
