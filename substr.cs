using System.IO;
using System;


namespace Day_3
{
    class Class1
    {
        public static void Main()
        {
            String s1 = "It is a bad Color";
            String s2 = "is a";
            if (s1.Contains(s2))
            {
                Console.WriteLine("s2 is a substring of s1");
            }
            else 
            {
                Console.WriteLine("s2 is not a substring of s1");
            }
        }
    }
}