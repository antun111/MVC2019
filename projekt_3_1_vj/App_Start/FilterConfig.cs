﻿using System.Web;
using System.Web.Mvc;

namespace projekt_3_1_vj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
