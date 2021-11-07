using System;

namespace MyFirstProgram
{
    class Program
    {
        interface IOne
        {
            void Name();

        }
        interface ITwo
        {

            void Email();
        }

        class Person : IOne, ITwo
        {
            public void Email()
            {
                Console.WriteLine("Email");

            }
            public void Name()
            {
                Console.WriteLine("Person");

            }
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Email();
            p.Name();

        }
    }
}
