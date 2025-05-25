namespace GoshehArtWebApp.Services
{
    public static class FilePathProvider
    {
        public static string UploadsRoot =>
            Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.FullName, "Uploads");

        public static string ThumbnailsRoot =>
            Path.Combine(UploadsRoot, "Thumbnails");

        public static string ToWebPath(string fullPath)
        {
            var basePath = Directory.GetParent(Environment.CurrentDirectory)!.FullName + Path.DirectorySeparatorChar;
            if (fullPath.StartsWith(basePath))
            {
                return fullPath.Substring(basePath.Length).Replace("\\", "/");
            }
            return fullPath.Replace("\\", "/"); // fallback, just normalize slashes
        }


        public static string GetFullPath(string relativePath)
        {
            return Path.Combine(UploadsRoot, relativePath);
        }
    }
}
