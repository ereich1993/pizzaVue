using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PizzaVueBackend.Helpers
{
    public static class MailService
    {
        

        static bool mailSent = false;
       
        public static void Initialize()
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("i6056961@gmail.com", ""),
                EnableSsl = true
            };
            client.Send("i6056961@gmail.com", "i6056961@gmail.com", "test", "testbody");
            Console.WriteLine("Sent");
            Console.ReadLine();
        }
    }
}
