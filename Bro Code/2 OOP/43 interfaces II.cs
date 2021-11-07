using System;

namespace MyFirstProgram
{
    class Program
    {
        interface IData
        {
            void Name();
            void Email();
        }

        class ALi : IData
        {
            public void Email()
            {
                Console.WriteLine(" Ali Email");

            }
            public void Name()
            {
                Console.WriteLine("ali");

            }
        }
        class Usman : IData
        {
            public void Email()
            {
                Console.WriteLine("usman email");

            }
            public void Name()
            {
                Console.WriteLine("usman");

            }
        }
        static void Main(string[] args)
        {
            IData[] arr = new IData[]
            {
                new ALi(), new Usman()
            };

            foreach (IData i in arr)
            {
                i.Email();
                i.Name();
            }



        }
    }
}
