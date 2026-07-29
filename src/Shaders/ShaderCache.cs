using System;
using System.IO;
using System.Text.Json;

namespace RyujinxLauncher
{
    public static class ShaderCache
    {
        private static readonly string CACHE_ROOT = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Ryujinx", "games");

        public static string GetCachePath(string titleId)
            => Path.Combine(CACHE_ROOT, titleId, "cache", "shader", "host");

        public static int GetCachedShaderCount(string titleId)
        {
            var path = GetCachePath(titleId);
            if (!Directory.Exists(path)) return 0;
            return Directory.GetFiles(path, "*.toc").Length;
        }

        public static void ClearCache(string titleId)
        {
            var path = GetCachePath(titleId);
            if (Directory.Exists(path)) Directory.Delete(path, recursive: true);
        }

        public static long GetCacheSize(string titleId)
        {
            var path = GetCachePath(titleId);
            if (!Directory.Exists(path)) return 0;
            long total = 0;
            foreach (var f in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
                total += new FileInfo(f).Length;
            return total;
        }
    }
}