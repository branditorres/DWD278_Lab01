﻿using System.Web;
using System.Web.Mvc;

namespace DWD278_Lab01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
