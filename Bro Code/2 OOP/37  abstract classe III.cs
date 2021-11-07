using System;

namespace MyFirstProgram
{

    //  one simple class derived from two abstract classes , will implement all 
    // abstract methods from both classes
    class Program
    {
        abstract class Demo
        {
            public abstract void Name();
             
        }

        abstract class Data : Demo
        {
            public abstract void Email();
        }
        class Person : Data
        {
            public override void Name()
            {
                Console.WriteLine("Name");
            }

            public override void Email()
            {
                Console.WriteLine("Email");
            }
        }
        static void Main(string[] args)
        {
            Person a = new Person();
            a.Email();




        }
    }
}
