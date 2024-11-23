using OrchardCore.Logging;
using static OpenIddict.Abstractions.OpenIddictConstants.Permissions;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.Navigation;
using BadgerBJJ.AppointmentsModule.AdminMenu;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseNLogHost();

builder.Services
    .AddOrchardCms() 
    .ConfigureServices(services =>
    {
        
    })
    .Configure((app, routes, services) =>
    {
        routes.MapAreaControllerRoute(
        name: "Home",
        areaName: "BadgerBJJ.MainTheme",
        pattern: "{controller=Home}/{action=Index}/{id?}");

        routes.MapAreaControllerRoute(
        name: "Home",
        areaName: "BadgerBJJ.MainTheme",
        pattern: "{controller}/{action}/{id?}",
        defaults: new { controller = "Home", action = "Index" });
    });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles(); 
app.UseOrchardCore();  
app.Run();
