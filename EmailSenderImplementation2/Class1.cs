using EmailSenderInterfaces;
using Ninject.Modules;
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

    public class EmailSenderModule2 : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IEmailSender>().To<EmailSender2>();
        }
    }

}
