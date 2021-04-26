using System.IO;
using System;

class Program
{
   void sum()
   {
       Console.WriteLine("I am empty");
   }
   void sum(int a, int b)
   {
       Console.WriteLine("Sum of a+b ="+ (a+b));
       }
       void sum(int a, int b,int c)
       {
           Console.WriteLine("Sum of a+b+c=" +(a+b+c));
       }
       void sum (sting a, string b)
       {
           Console.WriteLine("concat two str"+(a+""+b));
       }
       static void Main()
       {
           Class1 class1 = new Class1();
           class1.sum();
           class1.sum(1,2);
           class1.sum(1,2,3);
           class1.sum("abi","rami");
           Console.ReadLine();
       }
}
