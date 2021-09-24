using System;
using System.IO;

public static class FindFolder
{
    public static string Content() => FindAdjacentFolder("content");

    public static string Theme(string name)
    {
        string themes = FindAdjacentFolder("themes");
        string theme = Path.Combine(themes, name);
        if (!Directory.Exists(theme))
            throw new ArgumentException($"theme not found: {theme}");
        return theme;
    }

    private static string FindAdjacentFolder(string targetFolderName, string startSearchAt = "./", int maxDepth = 20)
    {
        string currentPath = Path.GetFullPath(startSearchAt);
        for (int i = 0; i < maxDepth; i++)
        {
            string possibleFolderPath = Path.Join(currentPath, targetFolderName);

            if (Directory.Exists(possibleFolderPath))
            {
                return possibleFolderPath;
            }

            currentPath = Path.GetDirectoryName(currentPath)
                ?? throw new InvalidOperationException($"Adjacent folder named '{targetFolderName}' not found at any level");
        }

        throw new InvalidOperationException($"Adjacent folder named '{targetFolderName}' not found in {maxDepth} levels");
    }

}