using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The Console.ReadLine() method returns a string. 
            Therefore, you cannot get information from another data type, such as int
            */
            
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");

            Console.ReadKey();
        }
    }
}