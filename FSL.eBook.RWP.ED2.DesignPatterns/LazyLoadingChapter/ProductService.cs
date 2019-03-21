using FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter;
using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.LazyLoadingChapter
{
    public sealed class ProductService
    {
        private IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = DependencyResolver.Current.GetService<IProductRepository>();
                }

                return _productRepository;
            }
        }
    }
}