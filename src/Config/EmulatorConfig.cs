using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace RyujinxLauncher
{
    public class EmulatorConfig
    {
        public string Renderer    { get; set; } = "Vulkan";
        public string Resolution  { get; set; } = "1920x1080";
        public bool   LDNEnabled  { get; set; } = true;
        public bool   PPTCEnabled { get; set; } = true;
        public bool   NVDecEnabled{ get; set; } = true;
        public int    AudioVolume { get; set; } = 100;

        private static readonly string ConfigPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "RyujinxLauncher", "config.json");

        public static EmulatorConfig Load()
        {
            if (!File.Exists(ConfigPath)) return new EmulatorConfig();
            try { return JsonSerializer.Deserialize<EmulatorConfig>(File.ReadAllText(ConfigPath)) ?? new(); }
            catch { return new EmulatorConfig(); }
        }

        public void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(ConfigPath)!);
            File.WriteAllText(ConfigPath, JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}