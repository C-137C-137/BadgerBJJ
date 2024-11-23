using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.ResourceManagement;

namespace BadgerBJJ.MainTheme
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
           
        }

        public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
         routes.MapAreaControllerRoute(
         name: "Default",
         areaName: "BadgerBJJ.MainTheme",
         pattern: "{controller=Home}/{action=Index}");

        routes.MapAreaControllerRoute(
        name: "Home",
        areaName: "BadgerBJJ.MainTheme",
        pattern: "{controller}/{action}",
        defaults: new { controller = "Home", action = "Index" });
        }

    }
}
