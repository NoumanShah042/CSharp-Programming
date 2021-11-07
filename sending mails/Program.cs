using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Web;
using System.Net.Mail;

namespace Prog_Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // from , to , subject , bodt
                MailMessage message = new MailMessage( );
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("hello042hello@gmail.com");
                message.To.Add(new MailAddress("noumanrehman042@gmail.com"));
                message.Subject = "Test";                  
                message.Body = "Salam !";

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("hello042hello@gmail.com", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);
                Console.WriteLine("Mail sent");
            }
            catch (Exception) {

                Console.WriteLine("Error");
            }

        }
        
    }
}
