using System;
using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.SingletonChapter
{
    public sealed class SingletonController : 
        Controller
    {
        public ActionResult Index()
        {
            Log.Instance.LogException(new Exception("test"));

            return Content("Singleton"); 
        }
    }
}