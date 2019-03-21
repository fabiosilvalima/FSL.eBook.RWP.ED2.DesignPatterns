using FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter;
using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.ServiceLocatorChapter
{
    public sealed class ProductController : 
        Controller
    {
        private IProductRepository ProductRepository
        {
            get
            {
                return DependencyResolver.Current.GetService<IProductRepository>();
            }
        }

        public ActionResult Index()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            ProductRepository.Insert(product);

            return Content("Service Locator Pattern");
        }
    }
}