using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Day_3
{
    //Readonly and cost keyword
    class Class8
    {
        public readonly double pi =3.14;
        public Class8 (double pi)
        {
            this.pi = pi;
        }
        public static void Main()
        {
            const double PI = 3.14;
             //readonly int pi = 3.14;
           Class8 class8 = new Class8(PI);
            Console.WriteLine(PI);
            Console.ReadLine();
        }
    }
}