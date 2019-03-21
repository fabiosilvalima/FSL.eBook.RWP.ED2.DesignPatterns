using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.AdapterChapter
{
    public sealed class AdapterController : 
        Controller
    {
        public ActionResult Index()
        {
            var square = new Square() { Size = 50 };
            var calc = new CalcAdapter();
            var area = calc.CalculateArea(square);

            return View($"ADAPTER PATTERN AREA of square {square.Size}: {area}");
        }
    }
}