using FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter;
using FSL.eBook.RWP.ED2.DesignPatterns.SingletonChapter;
using FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter;
using FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario1;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Lifestyles;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FSL.eBook.RWP.ED2.DesignPatterns
{
    public class MvcApplication : 
        System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterDependencyResolver()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.UseRepository();
            container.UseUnitOfWorkScenario1();
            container.UseUnitOfWork();
            container.UseSingleton();

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
