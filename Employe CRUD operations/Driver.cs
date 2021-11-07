using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Driver
    {
        //  3:33:33

        static List<Employ> employList;

        public static void ShowEmployMain()
        {
            EmployCrud employCrud = new EmployCrud();
            employList= employCrud.Show();
            foreach (Employ i in employList)
            {
                Console.WriteLine(i);
            }
        }

        public static void UpdateEmployMain()
        {
            Employ employ = new Employ();

            Console.Write("Emp no : ");
            employ.Empno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Emp Name : ");
            employ.Name = Console.ReadLine();

            Console.Write("Emp Baic : ");
            employ.Basic = Convert.ToDouble(Console.ReadLine());

            EmployCrud employCrud = new EmployCrud();
            employCrud.UpdateEmploy(employ);
        }

        public static void DeleteEmployMain()
        {
            int empno;
            Console.WriteLine("enter employ number: ");
            empno = Convert.ToInt32(Console.ReadLine());
            EmployCrud employCrud = new EmployCrud();
            Console.WriteLine(employCrud.DeleteEmploy(empno));

        }
        public static void SearchEmployMain()
        {
            int empno;
            Console.WriteLine("enter employ number: ");
            empno = Convert.ToInt32(Console.ReadLine());
            EmployCrud employCrud = new EmployCrud();
            Employ result = employCrud.SearchEmploy(empno);
            if(result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("*** Record not Found ***");
            }


        }
        public static void AddEmployInput()
        {
            Employ employ = new Employ();
            Console.Write("Emp no : ");
            employ.Empno =Convert.ToInt32(Console.ReadLine());

            Console.Write ("Emp Name : ");
            employ.Name = Console.ReadLine();

            Console.Write ("Emp Baic : ");
            employ.Basic = Convert.ToDouble(Console.ReadLine());

            EmployCrud employCrud = new EmployCrud();
            employCrud.AddEmploy(employ);
        }
        static void Main(string[] args)
        {
            int ch = 0;
            do
            { 
                Console.WriteLine("\n--------------------");
                Console.WriteLine("1. Add Emplyee");
                Console.WriteLine("2. Show Employee");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Delete Employ");
                Console.WriteLine("5. Update Employ");
                Console.WriteLine("6. Exit");
                Console.WriteLine("--------------------");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployInput();
                        break;
                    case 2:
                        ShowEmployMain();
                        break;
                    case 3:
                        SearchEmployMain();
                        break;
                    case 4:
                        DeleteEmployMain();
                        break;
                    case 5:
                        UpdateEmployMain();
                        break;
                    case 6:
                        return;
                    default:
                        break;



                }
            } while (ch != 3);





        }
    }
}
