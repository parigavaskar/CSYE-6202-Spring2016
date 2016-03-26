using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        
        static void Main(string[] args)
        {

            User s1 = new User("Sandeep");
            
            
            
            
            Console.WriteLine("Select option:");
            Console.WriteLine("1. (Ss)how balance");
            Console.WriteLine("2. (Ww)withdraw");
            Console.WriteLine("3. (Dd)deposit");
            Console.WriteLine("4. (Qq)quit");
            int choice= Convert.ToInt32( Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine( s1.account.balance());
                    break;

                case 2:
                    Console.WriteLine("How much amount do you wish to withdraw");
                    float amount = Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("amount withdrawn");
                    s1.account.withdraw(amount);
                    break;
                case 3:
                    Console.WriteLine("how much amount to be deposited:");
                    float a = Convert.ToInt32(Console.ReadLine());
                    s1.account.deposit(a);
                    Console.WriteLine("amount deposited");
                    break;
                case 4:
                    Environment.Exit(0);
                    break;

            }
            Console.ReadLine();
        }
    }
}
