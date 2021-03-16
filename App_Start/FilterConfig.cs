using System.Web.Mvc;

namespace CIS4290SeniorProjectSpring2021
{
    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}