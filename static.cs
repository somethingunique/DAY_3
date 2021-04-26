using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    //static keyword
    //by default thease are sealed classes cannot inherit and cannot crreat a obj
    static class Class6
    {
        public static string Topic = "Static Class";
        public static void sum()
        {
            Console.WriteLine("hi");
        }
        
    }
   class Client
   {
       public static void Main()
       {Class6.sum();
       
           Console.WriteLine(Class6.Topic);
           Console.ReadLine();
       }
   }
}
   