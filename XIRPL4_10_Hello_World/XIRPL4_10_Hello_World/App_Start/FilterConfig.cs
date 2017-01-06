using System.Web;
using System.Web.Mvc;

namespace XIRPL4_10_Hello_World
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
