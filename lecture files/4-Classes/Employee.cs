using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Name Spaces are logic unit to Hold classes
namespace LearnProgramming.Classes
{

    //A classed of name 'Employee'
    class Employee
    {
        //Class Parameters
        public int id;
        public int age;
        public string name;

        //Default Constructor
        public Employee()
        {
            System.Console.WriteLine("default constructor is executed");
        }

        //Parameterized Constructor
        public Employee(int i,int a,string n)
        {
            id = i;
            age = a;
            name = n;
            System.Console.WriteLine("parameterized constructor is executed");
        }

        public void Show()
        {
            System.Console.WriteLine("ID:{0}, Name:{1}, Age:{2}", id, name, age);
        }
    }//End of Employee class


    //This class can't be inherited by any other class
    sealed class A
    {
    }

    class B
    {
        public virtual void Show()
        {
        }
    }

    class C : B
    {
        //Here we are overriding a method and also stopping its further overriding
        public sealed override void Show()
        {

        }
    }
}
