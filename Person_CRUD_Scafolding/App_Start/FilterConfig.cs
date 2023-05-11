using System.Web;
using System.Web.Mvc;

namespace Person_CRUD_Scafolding
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
