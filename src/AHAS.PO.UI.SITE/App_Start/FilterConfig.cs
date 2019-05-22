using System.Web;
using System.Web.Mvc;

namespace AHAS.PO.UI.SITE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
