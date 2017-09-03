using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PerfectPlace
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            Server.ClearError();
            
            if (exc is HttpException && ((HttpException)exc).GetHttpCode() == 401)
            {
                Response.Redirect("/Error/AccessDenied");
            }
            else if (exc is HttpException && ((HttpException)exc).GetHttpCode() == 403)
            {
                Response.Redirect("/Error/Forbidden");
            }
            else if (exc is HttpException && ((HttpException)exc).GetHttpCode() == 404)
            {
                Response.Redirect("/Error/NotFound");
            }
            else if (exc is HttpException && ((HttpException)exc).GetHttpCode() == 500)
            {
                Response.Redirect("/Error/Error");
            }
        }
    }
}
