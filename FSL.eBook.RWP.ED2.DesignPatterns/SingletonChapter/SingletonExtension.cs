using SimpleInjector;

namespace FSL.eBook.RWP.ED2.DesignPatterns.SingletonChapter
{
    public static class SingletonExtension
    {
        public static void UseSingleton(
            this Container container)
        {
            container.Register<ILog, DatabaseLog>(Lifestyle.Singleton);
        }
    }
}