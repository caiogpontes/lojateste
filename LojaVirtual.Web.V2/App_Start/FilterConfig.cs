﻿using LojaVirtual.Web.V2.HtmlHelpers;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Web.V2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            filters.Add(new InjectPageMetadataAttribute());
        }
    }
}
