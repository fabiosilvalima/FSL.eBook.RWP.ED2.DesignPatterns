using SimpleInjector;

namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public static class UnitOfWorkExtension
    {
        public static void UseUnitOfWorkScenario1(
            this Container container)
        {
            container.Register<IRegisterUnitOfWork, RegisterUnitOfWork>(Lifestyle.Singleton);
        }
    }
}