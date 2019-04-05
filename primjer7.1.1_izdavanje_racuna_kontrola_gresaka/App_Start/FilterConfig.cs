using System.Web;
using System.Web.Mvc;

namespace primjer7._1._1_izdavanje_racuna_kontrola_gresaka
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
