using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!"); // don't add \n at the end
            Console.WriteLine("Hello!"); // add \n at the end

            //This is a comment
            /*
             * this
             * is
             * a
             * multiline
             * comment
             */

            Console.WriteLine("BroCode");
            System.Console.WriteLine("ID:{0}, Name:{1}, Age:{2}", 27, "Nouman", 23);
            
            Console.ReadKey(); // input some character, to stop garbage 
        }
    }
}