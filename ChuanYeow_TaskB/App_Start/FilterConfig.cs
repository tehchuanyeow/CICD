﻿using System.Web;
using System.Web.Mvc;

namespace ChuanYeow_TaskB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
