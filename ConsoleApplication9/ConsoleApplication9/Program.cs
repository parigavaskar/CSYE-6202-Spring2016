using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {   
        internal int foo(int a, int b)
        {
            while(a> b)
            {
                a -= b;
               
            }
            return a;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine( p.foo(7,4));
            Console.ReadLine();

        }
    }
}
