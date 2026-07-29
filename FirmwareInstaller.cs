using System;
using System.IO;

namespace RyujinxLauncher
{
    public static class FirmwareInstaller
    {
        private static readonly string SYSTEM_PATH = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Ryujinx", "bis", "system", "Contents", "registered");

        public static bool FirmwareInstalled() =>
            Directory.Exists(SYSTEM_PATH) &&
            Directory.GetFiles(SYSTEM_PATH, "*.nca").Length > 0;

        public static int CountInstalledNCA() =>
            Directory.Exists(SYSTEM_PATH)
                ? Directory.GetFiles(SYSTEM_PATH, "*.nca").Length
                : 0;

        public static string GetStatusMessage()
        {
            if (!FirmwareInstalled())
                return "Firmware not found. Install via Tools → Install Firmware in Ryujinx.";
            return $"Firmware installed ({CountInstalledNCA()} NCA files)";
        }
    }
}