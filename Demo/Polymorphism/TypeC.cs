﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    internal class TypeC : TypeB
    {

        public int C {  get; set; }
        public TypeC(int a , int b , int c) : base(a,b)
        {
            C = c;
        }
        public new void fun01()
        {
            Console.WriteLine("I am Derived [Grand Child]");
        }
        override public void fun02()
        {
            Console.WriteLine($"Type C : A = {A}   B = {B}   C = {C}");
        }
    }
}
