using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties =  shortcut when no additional logic is required in the property
            //                                you do not have to define a field for a property,
            //                                you only have to write get; and/or set; inside the property                             

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);
            car.Model = "Ferrari";
            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }

    class Car
    {
        /*
         
         // instead of doing this    ----------------

            private String model;

            public String Model
            {
                get{ return model;}; 
                set { model = vaue };

            } 
         */

        //  just use this shortcut   ----------------
        public String Model { get; set; }

        public Car(String model)
        {
            this.Model = model;
        }
    }
}