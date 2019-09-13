using MailKit.Net.Imap;
using PizzaVueBackend.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaVueBackend.Helpers
{
    public static class MailService
    {
        
        public static SmtpClient client;
        static bool mailSent = false;
        public static AutoResetEvent resetEvent { get; set; }
        public static PizzaBackendDbContext ctx;


        
        public static void Initialize()
        {
            
            Task.Factory.StartNew(worker);
            resetEvent = new AutoResetEvent(false);
            client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("i6056961@gmail.com", ""),
                EnableSsl = true
            };
            
        }

        public static void worker()
        {
            while (!resetEvent.WaitOne(1))
            {
                if (true||DateTime.Now.Date.Hour==16 && DateTime.Now.Date.Minute == 0)
                {
                    try
                    {
                        
                      
                        var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:55299/api/Product/GetDailyRevenue");
                        httpWebRequest.ContentType = "application/json";
                        httpWebRequest.Method = "GET";

                        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var webResult = streamReader.ReadToEnd();
                            //events = JsonConvert.DeserializeObject<List<Event>>(webResult);

                        }
                        client.Send("i6056961@gmail.com", "i6056961@gmail.com", "test", "testbody");

                    }
                    catch (Exception e)
                    {
                        //events = new List<Event>();
                    }

                   
                }

            }
        }


    }
}
