using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    static class MaxExtendsMethod
    {
        public static void PrintEArr(this int[] elements)
        {
            foreach(int element in elements) { 
                Console.WriteLine(element);
            }
        }
    }
    
}
