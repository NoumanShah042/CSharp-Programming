using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //params keyword = a method parameter that takes a variable number of arguments.
            //                 The parameter type must be a single - dimensional array

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

            Console.WriteLine(total);
            Console.ReadKey();
        }

        //   use params keyword before type
        static double CheckOut(params double[] prices)
        {
            Console.WriteLine(prices.GetType()); // System.Double[]

            double total = 0;
            
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }

    }
}