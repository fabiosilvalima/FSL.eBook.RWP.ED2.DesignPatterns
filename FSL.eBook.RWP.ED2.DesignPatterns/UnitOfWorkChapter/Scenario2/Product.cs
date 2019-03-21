using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public sealed class Product : 
        IEntity
    {
        private readonly IProductRepository _repository;

        public Product(
            IProductRepository repository)
        {
            _repository = repository;
        }

        public Product() : 
            this(DependencyResolver.Current.GetService<IProductRepository>())
        {

        }

        public int? Id { get; set; }
        public string Name { get; set; }

        public void Insert()
        {
            _repository.Insert(this);
        }
    }
}