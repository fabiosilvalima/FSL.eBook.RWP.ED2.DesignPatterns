using System;
using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.SingletonChapter
{
    public sealed class Log
    {
        private static volatile ILog instance;
        private static object syncRoot = new Object();

        private Log() { }

        public static ILog Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = DependencyResolver.Current.GetService<ILog>();
                        }
                    }
                }

                return instance;
            }
        }
    }
}