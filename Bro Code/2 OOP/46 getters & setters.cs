using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //getters & setters = add security to fields by encapsulation
            //                    They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            car.Speed = 1000000000;   //  accessing property

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }
    class Car
    {
        private int speed;   //   make private field

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed   // it is better that property have same name as field(speed) with first letter capital 
        {
            get     //   getter , readable
            {
                return speed;
            }
            set     //  setter , writable
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }

    }
}