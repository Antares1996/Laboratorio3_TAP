using EmailSenderInterfaces;
using System;

namespace EmailSenderImplementation1
{
    public class EmailSender1 : IEmailSender
    {
        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("emailsender1: " + to + " -> " + body);
            return true;
        }
    }
}
