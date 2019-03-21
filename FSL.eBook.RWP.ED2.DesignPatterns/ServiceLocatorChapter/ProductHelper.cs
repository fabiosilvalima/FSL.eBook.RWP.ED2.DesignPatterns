using FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter;
using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.ServiceLocatorChapter
{
    public static class ProductHelper
    {
        public static IProductRepository ProductRepository()
        {
            var repository = DependencyResolver.Current.GetService<IProductRepository>();

            if (repository == null)
            {
                repository = new DapperSqlProductRepository();
            }

            return repository;
        }
    }
}