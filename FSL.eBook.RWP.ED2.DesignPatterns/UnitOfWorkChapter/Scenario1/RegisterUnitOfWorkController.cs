using FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter;
using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public sealed class RegisterUnitOfWorkController : 
        Controller
    {
        private readonly IRegisterUnitOfWork _unitOfWork;

        public RegisterUnitOfWorkController(IRegisterUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Together()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            var payment = new Payment()
            {
                Id = 1,
                Name = "payment 1",
                ProductId = product.Id
            };

            _unitOfWork.Insert(product, payment);

            return Content("Unit Of Work Pattern");
        }

        public ActionResult Separated()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "product 1"
            };

            _unitOfWork.ProductRepository.Insert(product);

            return Content("Unit Of Work Pattern");
        }
    }
}