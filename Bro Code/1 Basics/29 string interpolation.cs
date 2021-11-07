using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders
            
            //                        { value , space_assigned} ->  right align         
            //                        { value , - space_assigned}  ->  left align         

            String firstName = "Bro";
            String lastName = "Code";
            int age = 21;

            Console.WriteLine($"Hello {firstName} {lastName}.");    // Hello Bro Code.

            Console.WriteLine($"You are {age,10} old.");   //   You are         21 old.
            Console.WriteLine($"You are {age,-10} old.");  //   You are 21         old.

            Console.ReadKey();
        }
    }
}