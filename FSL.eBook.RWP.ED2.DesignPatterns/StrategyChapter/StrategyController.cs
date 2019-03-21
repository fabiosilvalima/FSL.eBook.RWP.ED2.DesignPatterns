using System.Collections.Generic;
using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.StrategyChapter
{
    public sealed class StrategyController : 
        Controller
    {
        public ActionResult Index()
        {
            var list = new List<string>()
            {
                "fabio",
                "silva",
                "lima"
            };

            var sort = new Strategy(new DescendingSortStrategy());
            sort.Sort(list);
            sort = new Strategy(new AscendingSortStrategy());
            sort.Sort(list);
            sort = new Strategy(new BubleSortStrategy());
            sort.Sort(list);

            return Content("Strategy");
        }
    }
}