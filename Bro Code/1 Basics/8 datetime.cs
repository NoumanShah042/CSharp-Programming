using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  https://www.tutorialsteacher.com/csharp/csharp-datetime
		// http://csharp.net-informations.com/language/date.htm    -- best

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            //Console.WriteLine(dt1);

            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);
           

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine(dt3.Date);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);


            // ***************************
            // DateTime Static Fields

            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            //Console.WriteLine(currentDateTime );
            //Console.WriteLine(currentDateTime.ToString());
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time

            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime


            // ***************************
            // Convert String to DateTime

            var str = "5/12/2020";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");
        }
    }
}
