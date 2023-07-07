using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public sealed class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("This is a sealed class which can;t be further inherited");
        }
        
    }
    /// <summary>
    /// this Derived class can;t inherit BaseClass because it is sealed  
    /// </summary>
    //public class Derived : BaseClass
    //{
    //    // this Derived class can;t inherit BaseClass because it is sealed  
    //}
}
