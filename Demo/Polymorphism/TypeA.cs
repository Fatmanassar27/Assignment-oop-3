using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    internal class TypeA
    {
        public int A {  get; set; }
        public TypeA(int a) 
        { 
            A = a;  
        }

        public void fun01 ()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        public virtual void fun02 ()
        {
            Console.WriteLine($"Type A : A = {A}");
        }
    }
}
