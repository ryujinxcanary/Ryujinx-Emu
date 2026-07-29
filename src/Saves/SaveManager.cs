using System;
using System.IO;
using System.Collections.Generic;

namespace RyujinxLauncher
{
    public class SaveManager
    {
        private readonly string _saveRoot;

        public SaveManager()
        {
            _saveRoot = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Ryujinx", "bis", "user", "save");
        }

        public IEnumerable<string> ListSaveSlots(string titleId)
        {
            var path = Path.Combine(_saveRoot, "0000000000000001", titleId);
            if (!Directory.Exists(path)) yield break;
            foreach (var dir in Directory.GetDirectories(path))
                yield return Path.GetFileName(dir);
        }

        public void BackupSave(string titleId, string destination)
        {
            var src = Path.Combine(_saveRoot, "0000000000000001", titleId);
            if (!Directory.Exists(src)) return;
            if (!Directory.Exists(destination)) Directory.CreateDirectory(destination);
            foreach (var file in Directory.GetFiles(src, "*", SearchOption.AllDirectories))
            {
                var rel  = Path.GetRelativePath(src, file);
                var dest = Path.Combine(destination, rel);
                Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
                File.Copy(file, dest, overwrite: true);
            }
        }
    }
}