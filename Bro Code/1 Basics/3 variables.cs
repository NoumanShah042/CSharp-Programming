using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 21; // whole integer
            double height = 300.5; // decimal number
            bool alive = false; // true or false
            char symbol = '@'; // single character
            String name = "Bro"; // a series of characters
            String userName = symbol + name;

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);
            Console.WriteLine("Your username is: " + userName);


            long myNum = 15000000000L;
            Console.WriteLine(myNum);

            float myNum2 = 5.75F;
            Console.WriteLine(myNum2);

            double myNum3 = 19.99D;
            Console.WriteLine(myNum3);

            // Scientific Numbers
            // A floating point number can also be a scientific number with an "e" to indicate the power of 10:
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);  // 35000
            Console.WriteLine(d1);  // 120000


            //  display type of var
            Console.WriteLine(name.GetType());
            // display size of int type
            Console.WriteLine(sizeof(int));




            Console.ReadKey();
        }
    }
}

/*

The general rules for constructing names for variables (unique identifiers) are:

Names can contain letters, digits and the underscore character (_)
Names must begin with a letter
Names should start with a lowercase letter and it cannot contain whitespace
Names are case sensitive ("myVar" and "myvar" are different variables)
Reserved words (like C# keywords, such as int or double) cannot be used as names

*/

/*

Data Type	Size	      Description
------------------------------------------
int	        4 bytes	 --   Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	    8 bytes	  --  Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	    4 bytes	  --  Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	    8 bytes	  --  Stores fractional numbers. Sufficient for storing 15 decimal digits
bool	    1 bit	 --   Stores true or false values
char	    2 bytes	 --   Stores a single character/letter, surrounded by single quotes
string	    2 bytes per character --  Stores a sequence of characters, surrounded by double quotes
------------------------------------------
*/