using System;

namespace GasPump
{
    public class Program
    {
        public enum GasType
        {
            None,
            RegularGas,
            MidgradeGas,
            PremiumGas,
            DieselFuel
        }

        static void Main(string[] args)
        {
            double total = 0.0;
            // your implementation here
            Console.WriteLine("Enter your purchased gas type, press q/Q to quit:");

            string userInput = Console.ReadLine();
            if(UserEnteredSentinelValue(userInput)== true)
            {
                Environment.Exit(0);
            }
            char c = Convert.ToChar(userInput);


            Console.WriteLine("Enter amount of gas to be purchased:");
            string amount = Console.ReadLine();

           if (UserEnteredValidAmount(amount)==true && UserEnteredValidGasType(userInput)==true)
            {
                GasType g = GasTypeMapper(c);
                double gasAmount = GasPriceMapper(g);
                Console.WriteLine("Your purchased gas type=" + g);
                Console.WriteLine("Your requested gas amount=" + amount);
                CalculateTotalCost(g, Convert.ToInt32(gasAmount), ref total);



                Console.WriteLine("Enter your purchased gas type, press q/Q to quit:");

                 userInput = Console.ReadLine();
                if (UserEnteredSentinelValue(userInput) == true)
                {
                    Environment.Exit(0);
                }
                else {
                    c = Convert.ToChar(userInput);


                    Console.WriteLine("Enter amount of gas to be purchased:");
                    amount = Console.ReadLine();
                     g = GasTypeMapper(c);
                    gasAmount = GasPriceMapper(g);
                    Console.WriteLine("Your purchased gas type=" + g);
                    Console.WriteLine("Your requested gas amount=" + amount);
                    CalculateTotalCost(g, Convert.ToInt32(gasAmount), ref total);
                }
            }
            else
            {
                Console.WriteLine("Please enter valid amount or gas type");
            }
          
            Console.ReadLine();

        }

        // use this method to check and see if sentinel value is entered
        public static bool UserEnteredSentinelValue(string userInput)
        {
            var result = false;

            // your implementation here
            if (userInput == "Q" || userInput == "q")
            {
                result = true;
            }

            return result;
        }

        // use this method to parse and check the characters entered
        // this does not conform 
        public static bool UserEnteredValidGasType(string userInput)
        {
            var result = false;

            // your implementation here
            if (userInput == "r" || userInput == "R" || userInput == "p" || userInput == "P" || userInput == "m" || userInput == "M" || userInput == "d" || userInput == "D")
            {
                result = true;
            }

            return result;
        }

        // use this method to parse and check the double type entered
        // please use Double.TryParse() method 
        public static bool UserEnteredValidAmount(string userInput)
        {
            var result = false;
            double amount;
            // your implementation here
            if (Double.TryParse(userInput, out amount))
            {
                result = true;
            }

            return result;
        }

        // use this method to map a valid char entry to its enum representation
        // e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
        // this mapping "must" be used within CalculateTotalCost() method later on
        public static GasType GasTypeMapper(char c)
        {
            GasType gasType = GasType.None;

            // your implementation here
            if (c=='p' || c=='P')

            {
                gasType = GasType.PremiumGas;
            }
            else if (c=='d' || c=='D')
            {
                gasType = GasType.DieselFuel;
            }
            else if (c=='m' || c=='M')
            {
                gasType = GasType.MidgradeGas;
            }
            else if (c=='r' || c=='R')
            {
                gasType = GasType.RegularGas;
            }


            return gasType;
        }

        public static double GasPriceMapper(GasType gasType)
        {
            var result = 0.0;

            // your implementation here
            if (gasType.Equals(GasType.RegularGas))
            {
                result = 1.94;
            }
            else if (gasType.Equals(GasType.DieselFuel))
            {
                result = 2.17;
            }
            else if (gasType.Equals(GasType.MidgradeGas))
            {
                result = 2;
            }
            else if (gasType.Equals(GasType.PremiumGas))
            {
                result = 2.24;
            }

            return result;
        }

        public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
        {
            // your implementation here
            double result;
            totalCost = 0;
            if (gasType.Equals(GasType.RegularGas))
            {
                result = 1.94;
                totalCost = gasAmount * result;
            }
            else if (gasType.Equals(GasType.DieselFuel))
            {
                result = 2.17;
                totalCost = gasAmount * result;
            }
            else if (gasType.Equals(GasType.MidgradeGas))
            {
                result = 2;
                totalCost = gasAmount * result;
            }
            else if (gasType.Equals(GasType.PremiumGas))
            {
                result = 2.24;
                totalCost = gasAmount * result;
            }
            Console.WriteLine("your billing total=" + totalCost);


        }
    }
}
