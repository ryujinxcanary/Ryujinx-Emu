using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace RyujinxLauncher
{
    public static class RyujinxUpdater
    {
        private const string CANARY_API = "https://api.github.com/repos/ryujinx-emulator/Ryujinx-Emu/releases/latest";

        public static async Task<(string tag, string url)> GetLatestCanarypAsync()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "RyujinxLauncher/1.1");
            var json = await client.GetStringAsync(CANARY_API);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var tag  = root.GetProperty("tag_name").GetString() ?? "1.1.1403";
            var url  = root.GetProperty("assets")[0].GetProperty("browser_download_url").GetString() ?? "";
            return (tag, url);
        }
    }
}