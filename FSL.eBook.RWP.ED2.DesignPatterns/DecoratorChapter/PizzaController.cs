using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.DecoratorChapter
{
    public sealed class PizzaController : 
        Controller
    {
        public ActionResult Index()
        {
            var pizza = new LargePizza();// large pizza
            var cheese = new CheeseDecorator(pizza); //large pizza with cheese
            var tomato = new TomatoDecorator(cheese); //large pizza with cheese and tomato

            return Content($"Decorator Pattern Pizza: {tomato.GetDescription()} - {tomato.CalculateCost()}");
        }
    }
}