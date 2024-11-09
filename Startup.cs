using System;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace BadgerBJJ.Appointments
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
       
            services.AddScoped<IYourService, YourService>();
            services.AddControllersWithViews();



        }
    }
}
