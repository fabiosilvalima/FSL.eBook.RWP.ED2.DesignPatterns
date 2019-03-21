using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
