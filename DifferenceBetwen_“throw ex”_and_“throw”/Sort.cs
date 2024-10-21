using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetwen__throw_ex__and__throw_
{
    public static class Sort
    {
        public static List<int> SortList()
        {
            List<int> li = new List<int>();
            li.Add(4);
            li.Add(1);
            li.Add(2);
            li.Add(3);
            foreach (var i in li)
            {
                Console.WriteLine(i);
            }
           // li.Sort();
            for (int i = 0;i <li.Count; i++)
            {
                for (int j= 0; j < li.Count; j++)
                {
                    if (i ==0 )
                    {
                        break;
                    }
                    if (li[i] < li[j])
                    {
                        var temp = li[i];
                        li[i] = li[j]; 
                        li[j] = temp;
                    }
                }
            }
            foreach (var i in li)
            {
                Console.WriteLine(i);
            }
            return li;

        }
       public static List<string> SortListOfString()
        {
            List<string> li = new List<String>();
            li.Add("bbb");
            li.Add("Kousick");
            li.Add("Manash");
            li.Add("Dholey");
            li.Add("abc");
            foreach (var i in li)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if (string.Compare(li[i], li[j]) <0)
                    {
                        var temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            foreach (var i in li)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------------------------");
            return li;
        }


        //Write a function to compare two strings and return the result in int type.
        //public int MyCompare(string s1, string s2)
        //{


        //    return 0;
        //}
        public static object BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return null;
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                }
                else
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
            }
        }
    }
}
