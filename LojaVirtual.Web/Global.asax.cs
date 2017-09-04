using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Web.Infraestrutura;
using System.Web.Mvc;
using System.Web.Routing;

namespace LojaVirtual.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.Add(typeof(Carrinho), new CarrinhoModelBinder());
        }
    }
}
