public class FilePathProvider
{
    private readonly IWebHostEnvironment _env;

    public FilePathProvider(IWebHostEnvironment env)
    {
        _env = env;
    }
    
    //for staging 
    public string RobotsTxtPath => Path.Combine(_env.WebRootPath ?? "wwwroot", "robots.txt");
    public string UploadsRoot => Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.FullName, "Uploads");

    public string ThumbnailsRoot => Path.Combine(UploadsRoot, "Thumbnails");

    public string WebAssetsRoot => Path.Combine(_env.WebRootPath, "Assets");

    public string ToWebPath(string fullPath)
    {
        var uploadsRoot = Path.GetFullPath(UploadsRoot) + Path.DirectorySeparatorChar;
        var webRoot = Path.GetFullPath(_env.WebRootPath) + Path.DirectorySeparatorChar;

        if (fullPath.StartsWith(uploadsRoot, StringComparison.OrdinalIgnoreCase))
        {
            var relativePath = fullPath.Substring(uploadsRoot.Length);
            return "/Uploads/" + relativePath.Replace("\\", "/");
        }

        if (fullPath.StartsWith(webRoot, StringComparison.OrdinalIgnoreCase))
        {
            var relativePath = fullPath.Substring(webRoot.Length);
            return "/" + relativePath.Replace("\\", "/");
        }

        // Debug fallback
        return "/unmapped/" + fullPath.Replace("\\", "/");
    }

    public string GetFullPath(string relativePath)
    {
        return Path.Combine(UploadsRoot, relativePath);
    }
}
