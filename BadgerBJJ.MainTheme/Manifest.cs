using OrchardCore.DisplayManagement.Manifest;
using OrchardCore.Modules.Manifest;

[assembly: Theme(
    Name = "BadgerBJJ.MainTheme",
    Id = "BadgerBJJ.MainTheme",
    Author = "Bánfi Konrád",
    Website = "https://orchardcore.net",
    Version = "2.0.2",
    Description = "BadgerBJJ.MainTheme",
    Tags = new[] { "theme", "custom" },
    Dependencies = new[] { 
        "OrchardCore.Menu", 
        "OrchardCore.Themes", 
        "OrchardCore.Themes",
        "BadgerBJJ.AppointmentsModule"
    }
)]
public class Manifest
{

}