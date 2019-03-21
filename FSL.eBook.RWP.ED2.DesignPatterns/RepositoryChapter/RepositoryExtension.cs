using SimpleInjector;

namespace FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter
{
    public static class RepositoryExtension
    {
        public static void UseRepository(
            this Container container)
        {
            container.Register<IProductRepository, DapperSqlProductRepository>(Lifestyle.Singleton);
        }
    }
}