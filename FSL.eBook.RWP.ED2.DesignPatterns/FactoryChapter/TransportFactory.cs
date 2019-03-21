
using System;

namespace FSL.eBook.RWP.ED2.DesignPatterns.FactoryChapter
{
    public static class TransportFactory
    {
        public static ITransport CreateInstance(string name)
        {
            return Activator.CreateInstance(Type.GetType($"FSL.eBook.RWP.ED2.DesignPatterns.FactoryChapter.{name}")) as ITransport;
        }
    }
}