using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    class Class2
    {
        public int a; //
        Class2(int a)
        {
           this.a = a;
        }
        public static void Main()
        {
            Class2 class2= new Class2(2);
            Console.WriteLine(class2.a);
            Console.ReadLine();
        }
    }
}
   