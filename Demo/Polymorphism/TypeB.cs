using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    internal class TypeB : TypeA
    {

        public int B { get; set; }
        public TypeB(int a ,int b) : base(a)
        {
            B = b;
        }
        public new void fun01()
        {
            Console.WriteLine("I am Derived [Child]");
        }
        override public void fun02()
        {
            Console.WriteLine($"Type B : A = {A}   B = {B}");
        }
    }
}
