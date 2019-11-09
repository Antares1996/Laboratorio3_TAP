using EmailSenderInterfaces;
using System;
using TinyDependencyInjectionContainer;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var resolver = new InterfaceResolver("TDIC_Configuration.txt");
            var sender = resolver.Instantiate<IEmailSender>();
            sender.SendEmail("pippo", "pluto");
        }
    }
}
