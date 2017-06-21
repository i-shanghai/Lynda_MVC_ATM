using System.Web;
using System.Web.Mvc;

namespace Lynda_MVC_ATM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
