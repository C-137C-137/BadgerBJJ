using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

namespace BadgerBJJ.AppointmentsModule.AdminMenu
{
    public  class AdminMenu : INavigationProvider
    {
        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
                return Task.CompletedTask;

            //builder
            //    .Add(T["BJJ Schedule"], "10", schedule => schedule
            //        .AddClass("bjj-schedule")
            //        .Action("Index", "Admin", new { area = "BadgerBJJ.AppointmentsModule" })
            //        .LocalNav()
            //    );

            return Task.CompletedTask;
        }

        ValueTask INavigationProvider.BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            throw new NotImplementedException();
        }
    }
}
