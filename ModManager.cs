using System;
using System.Collections.Generic;
using System.IO;

namespace RyujinxLauncher
{
    /// <summary>
    /// Manages LayeredFS mods for Ryujinx.
    /// Mods path: %AppData%\Ryujinx\mods\contents\{titleId}\romfs\
    /// </summary>
    public class ModManager
    {
        private readonly string _modsRoot;

        public ModManager(string ryujinxDataPath = null)
        {
            ryujinxDataPath ??= Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Ryujinx");
            _modsRoot = Path.Combine(ryujinxDataPath, "mods", "contents");
        }

        public string GetModPath(string titleId) =>
            Path.Combine(_modsRoot, titleId.ToLower(), "romfs");

        public void EnsureModFolder(string titleId)
        {
            Directory.CreateDirectory(GetModPath(titleId));
        }

        public IEnumerable<string> ListInstalledMods(string titleId)
        {
            var path = GetModPath(titleId);
            if (!Directory.Exists(path)) yield break;
            foreach (var entry in Directory.GetDirectories(path))
                yield return Path.GetFileName(entry);
        }

        public bool RemoveMod(string titleId, string modName)
        {
            var path = Path.Combine(GetModPath(titleId), modName);
            if (!Directory.Exists(path)) return false;
            Directory.Delete(path, recursive: true);
            return true;
        }
    }
}