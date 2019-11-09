
using Ninject;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace TinyDependencyInjectionContainer
{
    public class InterfaceResolver
    {
        private string FileConfiguration;
        private Dictionary<string, string> d;
        private IKernel k = new StandardKernel();
        public InterfaceResolver(string namefile)
        {
            FileConfiguration = namefile;
            d = new Dictionary<string, string>();
            var a = Assembly.LoadFrom("..\\..\\..\\..\\EmailSenderImplementation1\\bin\\Debug\\netstandard2.0\\EmailSenderImplementation1.dll");
            //var b = Assembly.LoadFrom("..\\..\\..\\..\\EmailSenderImplementation2\\bin\\Debug\\netstandard2.0\\EmailSenderImplementation2.dll");
            k.Load(a);

        }

        public T Instantiate<T>() where T : class
        {
            return k.Get<T>();
            
        }
    }
}
