using ECommerce.Migrations;
using ECommerce.Models;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ECommerce
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<ECommerceContext,Configuration>());
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}
