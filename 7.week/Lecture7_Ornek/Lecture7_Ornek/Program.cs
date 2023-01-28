using System;
using System.Collections.Generic;


namespace Lecture7_Ornek
{
    delegate bool NumbersHandler(int n);
    class LiveCodingClass
    {
        //Declare the delegate
        //FIRST example
          //it references a method which return bool

        //SECOND example
        /*
        public class MailArgs : EventArgs  //specify the event args
        {
            public string subject;
            public DateTime sendDate;      //sendDate in tipi DateTime
            
            //Constructor
            public MailArgs(string sub, DateTime date)
            {
                this.subject = sub;
                this.sendDate = date;
            }
        }

        public class Webserver   //publisher
        {
            public delegate void NotificationEventHandler(object source, MailArgs args);
            public event NotificationEventHandler MailSent;

            //dotnet convention: event publisher methods should be protected, virtual, void and start named On+<name of the event>
            protected virtual void OnMailSent(MailArgs args)
            {
                //check if there are subscribers
                if(MailSent != null)
                {
                    MailSent(this, args);  //invoke method the delegate points to
                    //if there were no subscribers, there would be no method to invoke!
                }
            }

            //trigger the event(s)
            public void SendMail(string mailSubject)
            {
                Console.WriteLine("Sending an email to everyone...");

                //Notify the subscribers
                MailArgs mail_args = new MailArgs(mailSubject, DateTime.Now);
                OnMailSent(mail_args);
            }
        }

        public class MailSubscriber      //subscriber
        {
            public Webserver webserver;
            public string subsriberName;
            public MailSubscriber(Webserver publisherServer, string subName)
            {
                this.webserver = publisherServer;
                this.subsriberName = subName;
                // subscribe to event
                this.webserver.MailSent += MailReceived;
            }

            private void MailReceived(object sender, MailArgs args)
        }
        */
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            //FIRST example

            int[] filter_list = {6, 2, 4, 2, 6, 8, 6, 7, 1};
            
            //getting numbers less than 3...
            List<int> GetNumsLessThanThree(int[] numbers)
            {
                List<int> return_list = new List<int>();
                foreach (int number in numbers)
                {
                    if (number < 3) return_list.Add(number);
                }
                return return_list;
            }

            //getting numbers less than 5..
            List<int> GetNumsLessThanFive(int[] numbers)
            {
                List<int> return_list = new List<int>();
                foreach(int number in numbers)
                {
                    if (number < 5) return_list.Add(number);
                }
                return return_list;
            }

            List<int> result_3 = GetNumsLessThanThree(filter_list);
            List<int> result_5 = GetNumsLessThanFive(filter_list);

            Console.WriteLine("Result without delegates...");
            foreach(int res in result_3)
            {
                Console.WriteLine(res);
            }


            //we can do this better by using delegates...
            List <int> GetNumbers(int[] numbers, NumbersHandler num_checker)
            {
                List<int> return_list = new List<int>();
                foreach(int number in numbers)
                {
                    if (num_checker(number)) return_list.Add(number);
                }
                return return_list;
            }

            bool LessThanFive(int n) { return n < 5; }
            bool LessThanThree(int n) { return n < 3; }
            bool LessThanTen(int n) { return n < 10; }
            bool GreaterThanFive(int n) { return n > 5; }

            List<int> result_delegates = GetNumbers(filter_list, LessThanTen);
            Console.WriteLine("\nResult with delegates...");
            foreach(int res in result_delegates)
            {
                Console.WriteLine(res);
            }
            
            
        }

    }
}
