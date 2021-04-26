using System.IO;
using System;

class Class1
{
   int a;
   int b;
   Class1(int _a, int _b)
   {
       a= _a;
       b=_b;
   }
   public static Class1 operator+(Class1 _obj1, Class1 _obj2)
   {
       Class1 _obj3 = new Class1(0,0);
       _obj3.a = _obj1.a+ _obj2.a;
       _obj3.b = _obj1.b+ _obj2.b;
       return _obj3;
   }
   public static void Showvalues(Class1 _obj)
   {
       Console.WriteLine("a =" +_obj.a);
       Console.WriteLine("b =" +_obj.b);
   }
   public static void Main()
   {
       Class1 obj1= new Class1(1,2);
       Class1 obj2= new Class1(1,2);
       Class1 obj3= new Class1(0,0);
       obj3 =obj1 + obj2;
       Class1.Showvalues(obj3);
       Console.ReadLine();
   }
}