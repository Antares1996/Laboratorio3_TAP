using EmailSenderInterfaces;
using Ninject.Modules;
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

    public class EmailSenderModule1 : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEmailSender>().To<EmailSender1>();
        }
    }
}
