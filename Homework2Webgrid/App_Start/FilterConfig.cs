﻿using System.Web;
using System.Web.Mvc;

namespace Homework2Webgrid {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
