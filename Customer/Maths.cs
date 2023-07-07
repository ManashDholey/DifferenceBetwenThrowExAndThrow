using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
  public   class Maths
    {
        public int Num1;
        public int Num2;
        Random random = new Random();
        //[Obsolete()]
        public void Divide()
        {
            //
                for (long i = 0; i < 100000; i++)
                {
                  lock(this)
                      {
                        Num1 = random.Next(1, 2);
                        Num2 = random.Next(1, 2);
                        int result = Num1 / Num2;
                        Num1 = 0;
                        Num2 = 0;
                      }
                }
           
        }
    }
}
