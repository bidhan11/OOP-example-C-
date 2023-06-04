using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class A
    {
        protected int a = 30, b = 67, c = 44;
        public void add()
        {
            c = a + b;
            Console.WriteLine("Addition " + c);

        }
        public void sub()
        {
            c = a - b;
            Console.WriteLine("Subtraction " + c);
        }
    }
    class B:A
    {
        public void multiplication()
        {
            c = a + b;
            Console.WriteLine(c);
        }
    }
    class InheritLabs
    {
        static void Main(String[] args)
        {
            A a = new A();
            a.add();
            B b=new B();
            b.multiplication();
            b.sub();
        }
    }
}
