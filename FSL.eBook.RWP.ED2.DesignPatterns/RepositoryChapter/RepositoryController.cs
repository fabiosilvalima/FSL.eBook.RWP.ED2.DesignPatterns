using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter
{
    public sealed class RepositoryController : 
        Controller
    {
        private readonly IProductRepository _productRepository;

        public RepositoryController(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public ActionResult Index()
        {
            var product = new Product()
            {
                Id = 100,
                Name = "Product 100"
            };

            _productRepository.Insert(product);

            return Content("Repository Pattern");
        }
    }
}