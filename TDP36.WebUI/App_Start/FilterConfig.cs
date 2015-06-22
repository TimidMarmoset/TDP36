using System.Web;
using System.Web.Mvc;

namespace TDP36.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
        filters.Add(new HandleErrorAttribute());
        }
    }
}
