using System;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace BadgerBJJ.Appointments
{

    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IContentManager, ContentManager>();
            services.AddControllersWithViews();
        }

        public override void Configure(IApplicationBuilder app, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "BadgerBJJ.Appointments",
                pattern: "/welcome-to-badger-bjj",
                defaults: new { controller = "Home", action = "Index", contentItemId = "4s9ef0tgnzzdqv3bvd4h8t5pm2" }
            );



           );
        }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
   
}
