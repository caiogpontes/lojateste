using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //1 - Inicio

            routes.MapRoute(
                name: null,
                url: "",
                defaults: new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos",
                    categoria = (string)null,
                    pagina = 1
                }
            );

            //2

            routes.MapRoute(
                name: null,
                url: "Pagina{pagina}",
                defaults: new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos",
                    categoria = (string)null
                },
                constraints: new { pagina = @"\d+" }
            );

            //3

            routes.MapRoute(
                name: null,
                url: "{categoria}",
                defaults: new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos",
                    pagina = 1
                }
            );

            //4

            routes.MapRoute(
                name: null,
                url: "{categoria}/Pagina{pagina}",
                defaults: new
                {
                    controller = "Vitrine",
                    action = "ListaProdutos",
                },
                constraints: new { pagina = @"\d+" }
            );

            routes.MapRoute(
                "ObterImagem",
                "Vitrine/ObterImagem/{produtoId}",
                new { controller = "Vitrine", action = "ObterImagem", produtoId = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vitrine", action = "ListaProdutos", id = UrlParameter.Optional }
            );
        }
    }
}
