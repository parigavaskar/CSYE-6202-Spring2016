using System;
namespace FizzBuzz

{
	class Program
	{
		static void Main(string[] args)
		{   
            FizzBuzz f = new FizzBuzz();
            System.Console.WriteLine("Please enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            string answer= f.RunFizzBuzz(n);
            Console.WriteLine(answer);
            Console.ReadLine();
            
		}
	}
}
