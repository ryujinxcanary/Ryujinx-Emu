using System;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RyujinxLauncher
{
    /// <summary>
    /// Helper for prod.keys validation — the most common setup question for Ryujinx.
    /// prod.keys location: %AppData%\Ryujinx\system\prod.keys
    /// </summary>
    public static class KeysHelper
    {
        private static readonly string KEYS_DIR = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Ryujinx", "system");

        public static string ProdKeysPath  => Path.Combine(KEYS_DIR, "prod.keys");
        public static string TitleKeysPath => Path.Combine(KEYS_DIR, "title.keys");

        public static bool ProdKeysExist()   => File.Exists(ProdKeysPath);
        public static bool TitleKeysExist()  => File.Exists(TitleKeysPath);

        public static bool ValidateProdKeys()
        {
            if (!ProdKeysExist()) return false;
            var content = File.ReadAllText(ProdKeysPath);
            // prod.keys must contain master_key entries
            return Regex.IsMatch(content, @"master_key_\d{2}\s*=\s*[0-9a-fA-F]{32}");
        }

        public static void EnsureKeysDirExists()
        {
            Directory.CreateDirectory(KEYS_DIR);
        }

        public static string GetSetupInstructions()
        {
            return
                "Ryujinx keys and firmware setup:\n" +
                $"1. Place prod.keys at: {ProdKeysPath}\n" +
                "2. Install firmware via Tools → Install Firmware in Ryujinx\n" +
                "3. Firmware version must match or be older than your prod.keys version\n" +
                "4. Dump prod.keys from your Switch using Lockpick_RCM";
        }

        public static string GetStatusMessage()
        {
            if (!ProdKeysExist())
                return $"prod.keys NOT found. Expected: {ProdKeysPath}";
            if (!ValidateProdKeys())
                return "prod.keys exists but appears invalid — re-dump from your console";
            return $"prod.keys: OK ({ProdKeysPath})";
        }
    }
}