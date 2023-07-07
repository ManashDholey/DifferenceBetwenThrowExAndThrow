using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class BaseClass1
    {
        public virtual void Display()
        {
            Console.WriteLine("Virtual method");
        }
    }
    public class DerivedClass : BaseClass1
    {
        // Now the display method have been sealed and can;t be overridden  
        public override sealed void Display()
        {
            Console.WriteLine("Sealed method");
        }
    }
    public class ThirdClass : DerivedClass
    {
        //public override void Display()
        //{
        //    Console.WriteLine("Here we try again to override display method which is not possible and will give error");
        //}
    }
}
