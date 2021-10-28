using System;

class TestClass
{
    static void Main(string[] args)
    {
        bool isDevEnvironment = args.Length == 1 && args[0] == "local";

        var ssg = new Statix.Generator
        (
            contentFolder: FindFolder.Content(),
            themeFolder: FindFolder.Theme("primary"),
            sourceUrl: "https://github.com/swharden/Maui.Graphics/blob/main/content/",
            rootUrl: isDevEnvironment ? "http://localhost:8080/" : "https://maui.graphics/"
        );
        ssg.Generate();
        ssg.GenerateSitemap();
        Console.WriteLine($"Complete! {ssg.RootUrl}");
    }
}
