using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Bro Code";
            String phoneNumber = "123-456-7890";

            fullName = fullName.ToUpper();
            fullName = fullName.ToLower();
            Console.WriteLine(fullName);

            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumber);  // 1234567890

            String userName = fullName.Insert(0, "Mr.");
            Console.WriteLine(userName); //  Mr.bro code

            Console.WriteLine(fullName.Length); // 8

            String firstName = fullName.Substring(0, 3); //  ( startIndex , length )
            String lastName = fullName.Substring(4, 4); 

            Console.WriteLine(firstName);  // bro  
            Console.WriteLine(lastName);  // code

            Console.ReadKey();
        }
    }
}