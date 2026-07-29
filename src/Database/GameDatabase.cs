using System;
using System.Collections.Generic;

namespace RyujinxLauncher
{
    public static class GameDatabase
    {
        public record KnownGame(string TitleId, string Name, string Genre, bool LDNSupported);

        public static readonly IReadOnlyList<KnownGame> Library = new[]
        {
            new KnownGame("01007EF00011E000", "The Legend of Zelda: Tears of the Kingdom", "Action-Adventure", true),
            new KnownGame("0100ABF008968000", "Pokemon Scarlet",                           "RPG",             false),
            new KnownGame("01008D300C50C000", "Mario Kart 8 Deluxe",                       "Racing",           true),
            new KnownGame("0100F15003E64000", "Fire Emblem Engage",                        "Strategy",         false),
            new KnownGame("0100C2500FC20000", "Splatoon 3",                                "Shooter",          true),
            new KnownGame("0100A3D008C5C000", "Xenoblade Chronicles 3",                    "JRPG",             false),
            new KnownGame("010003F003A34000", "Metroid Dread",                             "Action",           false),
            new KnownGame("01006F8002326000", "Animal Crossing: New Horizons",             "Simulation",       false),
        };

        public static KnownGame? FindByTitleId(string titleId) =>
            Library.FirstOrDefault(g => g.TitleId.Equals(titleId, StringComparison.OrdinalIgnoreCase));

        public static IEnumerable<KnownGame> LDNGames() =>
            Library.Where(g => g.LDNSupported);
    }
}