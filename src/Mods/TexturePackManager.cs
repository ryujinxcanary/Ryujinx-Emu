using System;
using System.IO;

namespace RyujinxLauncher
{
    public static class TexturePackManager
    {
        private static readonly string MOD_ROOT = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Ryujinx", "mods", "contents");

        /// <summary>
        /// LayeredFS texture pack installation for Ryujinx.
        /// Place texture replacement files in romfs/ under the game's title ID.
        /// </summary>
        public static string GetTexturePackPath(string titleId)
            => Path.Combine(MOD_ROOT, titleId.ToLower(), "romfs", "textures");

        public static void Install(string titleId, string texturePath, string packName)
        {
            var dest = Path.Combine(GetTexturePackPath(titleId), packName);
            Directory.CreateDirectory(Path.GetDirectoryName(dest)!);
            File.Copy(texturePath, dest, overwrite: true);
        }
    }
}