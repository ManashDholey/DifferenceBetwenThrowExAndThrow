using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class GCExample
    {
        public static void GetMaxGeneration()
        {
            Console.WriteLine("GC Maximum Generations: " + GC.MaxGeneration);
        }
    }
  public  class BaseGC
    {
        public void Display()
        {
            Console.WriteLine("Example Method");
        }
    }
    public class Calci
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
    }
}
