using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LearnProgramming.Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*----------------1-ConstructorExecPrac.cs Testing -------------------*/
            Tester1.Test();
            /*-------------------------------------------------------------------*/


            /*----------------2-VirtualPrac.cs Testing -------------------*/
            Tester2.Test();
            /*-------------------------------------------------------------------*/

            /*----------------3-AbstractPrac.cs Testing -------------------*/
            Tester3.Test();
            /*-------------------------------------------------------------------*/

            /*----------------4-InterfacePrac.cs Testing -------------------*/
            Tester4.Test();
            /*-------------------------------------------------------------------*/

            /*----------------5-AccessModifiersPrac.cs Testing -------------------*/
            Tester5.Test();
            /*-------------------------------------------------------------------*/

            CCC obj = new CCC();
            obj.show1();

            System.Console.ReadKey();
        }
    }

    


}


