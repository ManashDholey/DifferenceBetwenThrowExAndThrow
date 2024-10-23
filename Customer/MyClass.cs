using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
  public  class TestFirst : IFirst, ISecond
    {
         void IFirst.Display()
        {
            Console.WriteLine("Display method from IFirst interface(TestFirst)");
        }
        public void Display()
        {
            Console.WriteLine("General Display method from TestFirst");
        }
    }


public class Test : IFirst, ISecond
    {
        public void Display()
        {
            Console.WriteLine("General Display method from Test");
        }
    }


    public  class MyClass : IFirst, ISecond
    {
        // Explicit implementation for IFirst
        void IFirst.Display()
        {
            Console.WriteLine("Display method from IFirst interface(MyClass)");
        }

        // Explicit implementation for ISecond
        void ISecond.Display()
        {
            Console.WriteLine("Display method from ISecond interface(MyClass)");
        }

        // General method implementation
        public void Display()
        {
            Console.WriteLine("General Display method from MyClass");
        }
    }
}
