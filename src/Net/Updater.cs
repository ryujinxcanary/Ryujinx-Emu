using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RyujinxLauncher
{
    public static class Updater
    {
        private const string GITHUB_API = "https://api.github.com/repos/ryujinx-emulator/Ryujinx-Emu/releases/latest";

        public static async Task<string> GetLatestVersionAsync()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "RyujinxLauncher");
            var json = await client.GetStringAsync(GITHUB_API);
            using var doc = JsonDocument.Parse(json);
            return doc.RootElement.GetProperty("tag_name").GetString() ?? "unknown";
        }

        public static bool IsUpdateAvailable(string current, string latest)
        {
            if (int.TryParse(current.Replace(".", ""), out var c) &&
                int.TryParse(latest.Replace(".", ""), out var l))
                return l > c;
            return false;
        }
    }
}