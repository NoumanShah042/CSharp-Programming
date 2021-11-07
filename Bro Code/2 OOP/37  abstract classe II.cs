using System;

namespace MyFirstProgram
{
    class Program
    {
        abstract class Animal
        {
            public abstract void name();
            public abstract void type();
        }

        class Lion : Animal
        {
            public override void name()
            {
                Console.WriteLine("name is Animal");
            }

            public override void type()
            {
                Console.WriteLine("Lion is wild");
            }
        }
        class Rabbit : Animal
        {
            public override void name()
            {
                Console.WriteLine("name is Rabbit");
            }

            public override void type()
            {
                Console.WriteLine("Rabbit is runner");
            }
        }
        static void Main(string[] args)
        {
            Animal[] arr = new Animal[]
            {
                new Lion(), new Rabbit()
            };
            foreach(Animal a in arr)
            {
                a.name();
                a.type();
            }

            


        }
    }
}
