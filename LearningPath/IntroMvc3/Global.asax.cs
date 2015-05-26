using IntroMvc3.Models;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IntroMvc3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new OdeToFoodDBInitializer());

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }

    public class OdeToFoodDBInitializer : DropCreateDatabaseIfModelChanges<OdeToFoodDB>
    {
        protected override void Seed(OdeToFoodDB context)
        {
            base.Seed(context);

            context.Restaurants.Add(new Restaurant
            {
                Name = "Marrakesh",
                Address = new Address
                {
                    City = "Washington",
                    State = "D.C.",
                    Country = "USA"
                }
            });

            context.Restaurants.Add(new Restaurant
            {
                Name = "Sabatino's",
                Address = new Address
                {
                    City = "Baltimore",
                    State = "MD",
                    Country = "USA"
                }
            });

            context.Restaurants.Add(new Restaurant
            {
                Name = "The Kings Contrivance",
                Address = new Address
                {
                    City = "Columbia",
                    State = "MD",
                    Country = "USA"
                }
            });

            context.SaveChanges();
        }
    }
}
