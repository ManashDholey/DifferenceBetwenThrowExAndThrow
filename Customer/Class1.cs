using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class SimpleCustomer: ICustomer
    {
        public void Calculate()
        {
            Console.WriteLine("Simple Customer!!");
        }
    }
    public class DisCountedCustomer: ICustomer
    {
        public void Calculate()
        {
            Console.WriteLine("DisCounted  Customer!!");
        }
    }

    public interface ICustomer
    {
        void Calculate();
    }

}
