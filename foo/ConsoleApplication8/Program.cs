using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
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
            p.foo(5, 1);
        }
    }
}
