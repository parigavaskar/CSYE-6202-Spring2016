using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.fizzBuzz(x);

        }

        public void fizzBuzz(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
