using SimpleInjector;

namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter
{
    public static class UnitOfWorkExtension
    {
        public static void UseUnitOfWork(
            this Container container)
        {
            container.Register<Scenario1.IRegisterUnitOfWork, Scenario1.RegisterUnitOfWork>(Lifestyle.Singleton);
            container.Register<Scenario2.IProductRepository, Scenario2.DapperSqlProductRepository>(Lifestyle.Singleton);
            container.Register<Scenario2.IUnitOfWork, Scenario2.UnitOfWork>(Lifestyle.Singleton);
        }
    }
}