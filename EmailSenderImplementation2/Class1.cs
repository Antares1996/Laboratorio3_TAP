using EmailSenderInterfaces;
using System;

namespace EmailSenderImplementation2
{
    public class EmailSender2 : IEmailSender
    {
        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("emailsender2: " + to + " -> " + body);
            return true;
        }
    }
}
