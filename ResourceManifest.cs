public class ResourceManifest : IResourceManifestProvider
{
    public void BuildManifests(IResourceManifestBuilder builder)
    {
        var manifest = builder.Add();

        manifest
            .DefineStyle("BadgerBJJ.MainTheme-styles")
            .SetUrl("~/BadgerBJJ.MainTheme/css/styles.css")
            .SetVersion("1.0.0");

        // Add other resources like scripts if needed
        manifest
            .DefineScript("BadgerBJJ.MainTheme-scripts")
            .SetUrl("~/BadgerBJJ.MainTheme/js/site.js")
            .SetVersion("1.0.0");
    }
}