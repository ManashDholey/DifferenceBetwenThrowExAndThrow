using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
   public  class FactoryCustomer
    {
        List<ICustomer> cust = new List<ICustomer>();
       public FactoryCustomer()
        {
            cust.Add(new SimpleCustomer());
            cust.Add(new DisCountedCustomer());
        }
        public ICustomer Create(int i)
        {
            return cust[i];
        }
    }
}
