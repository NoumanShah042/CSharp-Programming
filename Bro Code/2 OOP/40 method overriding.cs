using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //method overriding = provides a new version of a method inherited from a parent class
            //                    Inherited method must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism 

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
    }
    class Animal
    {

        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }



    //  To create an overriding method , the method that is inherited , must be virtual abstract or already overriden.

    /*
     Other way is to use abstract keyword with both inherited class and its method, with no implementation of method.
    
     abstract class Animal
    {
        public abstract void Speak();
    }
     
    */
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {

    }


}

