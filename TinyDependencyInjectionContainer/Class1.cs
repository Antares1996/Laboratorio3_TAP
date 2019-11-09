using Ninject;
using System;

namespace TinyDependencyInjectionContainer
{
    public class InterfaceResolver
    {
        private string FileConfiguration;
        public InterfaceResolver(string namefile)
        {
            FileConfiguration = namefile;

        }

        public T Instantiate<T>() where T : class
        {
            using(var Kernel = new StandardKernel())
            {
                Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
                Kernel.Load("..\\..\\..\\..\\EmailSenderImplementation1\\bin\\Debug\\netstandard2.0\\EmailSenderImplementation1.dll");
                Kernel.Load("..\\..\\..\\..\\EmailSenderImplementation1\\bin\\Debug\\netstandard2.0\\EmailSenderInterfaces.dll");
                return Kernel.Get<T>();
            }
        }
    }
}
