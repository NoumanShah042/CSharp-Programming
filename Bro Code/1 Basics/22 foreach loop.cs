using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = a simpler way to iterate over an array, but it's less flexible
            // syntax:
            //  foreach (type variableName in arrayName) { ...  }
            
            String[] cars = { "BMW", "Mustang", "Corvette" };

            foreach (String car in cars)
            {
                Console.WriteLine(car+"  -  "+ car.GetType());
            }

            Console.ReadKey();
        }
    }
}