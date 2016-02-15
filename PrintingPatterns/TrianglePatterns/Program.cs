using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

		static void DisplayPatternA()
		{
			// your implementation here
            for(int i=1; i<=10; i++)
            {
                for (int j = 1; j <= i; j++)
                { Console.Write("*"); }

                Console.WriteLine("");
            }
            

        }

        static void DisplayPatternB()
		{
			// your implementation here
            for(int i=10; i>=1; i--)
            {
                for(int j=1; j<= i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine("");
            }
		}

		static void DisplayPatternC()
		{
			// your implementation here
            for(int i=10; i>=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for(int a=10;a>=i; a--)
                Console.Write(" ");
            }
            Console.WriteLine();
        }

		static void DisplayPatternD()
		{
			// your implementation here
            for(int i=1; i<=10; i++)
            {
                for(int j=1; j<=10-i; j++)
                {
                    Console.Write(" ");
                }
                for(int a=1;a<=i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
		}
	}
}
