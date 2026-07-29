using System;
using System.Threading.Tasks;

namespace RyujinxLauncher
{
    public static class LDNHelper
    {
        /// <summary>
        /// LDN multiplayer for Ryujinx — play Switch games online with friends.
        /// Ryujinx LDN: connect players via internet tunnel without Nintendo Switch Online.
        /// </summary>
        public static string GetLDNSetupGuide()
        {
            return
                "Ryujinx LDN multiplayer setup:\n" +
                "1. Open Ryujinx → Options → Network\n" +
                "2. Set Network Interface to your active LAN/Wi-Fi adapter\n" +
                "3. Enable 'Enable LDN network'\n" +
                "4. All players must use the same Ryujinx version with LDN enabled\n" +
                "5. Create or join a room from the game's local wireless menu";
        }

        public static bool IsLDNGame(string titleId)
        {
            var game = GameDatabase.FindByTitleId(titleId);
            return game?.LDNSupported ?? false;
        }
    }
}