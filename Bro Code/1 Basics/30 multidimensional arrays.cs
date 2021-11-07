using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        { 

            String[,] parkingLot = {    
                                        { "Mustang", "F-150", "Explorer", "Honda" },
                                        { "Corvette", "Camaro", "Silverado" , "Corolla"},
                                        { "Corolla", "Camry", "Rav4" , "Pajero"}
                                   };

            parkingLot[0, 2] = "Fusion";  // array at index 0 , element at index 2
            parkingLot[2, 0] = "Tacoma";

            /*
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */

            //  GetLength(int dimension) ->  return the # of elements in the specified dimension
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
                
            }
             
            Console.ReadKey();
        }
    }
}