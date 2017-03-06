using Avensia.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace Avensia
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DataInit.InitializeDatabase();
            UnityMapper.InitMappings();
        }
    }
}
