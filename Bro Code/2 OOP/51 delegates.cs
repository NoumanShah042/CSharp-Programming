using System;
 

namespace Prog_Practice3
{
    delegate int MyDel(int a, int b); // creating deleet
    class Program
    {
        
        public static int AddNum(int a , int b)
        {
            Console.WriteLine("adding num");
            return a + b;
        }
        public static int MultNum(int a, int b)
        {
            Console.WriteLine("Multiply num");
            return a * b;
        }
         
        
        static void Main(string[] args)
        {
            MyDel del = new MyDel(AddNum);  // //create delegate instances
            del += MultNum;
            int result = del(10, 13);
            Console.WriteLine(result);


            //MyDel del = new MyDel(AddNum);
            //int result = del(20, 12);
            //Console.WriteLine(result);

            //del = MultNum;
            //result = del(10, 13);
            //Console.WriteLine(result);
        }

    }
}


/*
 
 
 
 delegate int NumberChanger(int n);
namespace DelegateAppl {
   class TestDelegate {
      static int num = 10;
      
      public static int AddNum(int p) {
         num += p;
         return num;
      }
      public static int MultNum(int q) {
         num *= q;
         return num;
      }
      public static int getNum() {
         return num;
      }
      static void Main(string[] args) {
         //create delegate instances
         NumberChanger nc;
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
         
         nc = nc1;
         nc += nc2;
         
         //calling multicast
         nc(5);
         Console.WriteLine("Value of Num: {0}", getNum());
         Console.ReadKey();
      }
   }
}
 
 */






/*
 * 
 * 
 * https://www.tutorialspoint.com/csharp/csharp_delegates.htm
 
 C# delegates are similar to pointers to functions, in C or C++.
A delegate is a reference type variable that holds the reference to a method. 
 The reference can be changed at runtime.

 **********************************
 
 public delegate int MyDelegate (string s);

The preceding delegate can be used to reference any method that has a single string parameter and returns an int type variable.
Syntax for delegate declaration is −

delegate <return type> <delegate-name> <parameter list>
 
 
 
 */
