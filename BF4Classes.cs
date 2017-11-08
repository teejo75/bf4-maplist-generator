using System;
using System.Collections.Generic;

namespace BF4MapListGenerator
{
    [Flags]
    public enum GameTypes : long
    {
        /// <summary>
        /// A list of game types that a map can belong to.
        /// This is used as a flag during map list population.
        /// </summary>
        NONE = 0,
        CONQUESTLARGE0 = 1, // Up to 64 players
        CONQUESTSMALL0 = 2, // Up to 32 players
        RUSHLARGE0 = 4, // Up to 32 players
        SQUADDEATHMATCH0 = 8, // Up to 16 players
        TEAMDEATHMATCH0 = 16, // Up to 24 players
        DOMINATION0 = 32, // Up to 20 players
        ELIMINATION0 = 64, // Up to 10 players
        OBLITERATION = 128, // Up to 32 players
        AIRSUPERIORITY0 = 256, // Up to 24 players
        CAPTURETHEFLAG0 = 512, // Up to 32 players
        CARRIERASSAULTLARGE0 = 1024, // Up to 64 players (Guessing here)
        CARRIERASSAULTSMALL0 = 2048, // Up to 32 players (Guess)
        CHAINLINK0 = 4096, // 32 Players (Guess)
        SQUADOBLITERATION0 = 8192,
        GUNMASTER0 = 16384,
        GUNMASTER1 = 32768,
        SQUADDEATHMATCH1 = 65536,
        TEAMDEATHMATCH1 = 131072,

        // Compound enums
        BASE = CONQUESTLARGE0 | CONQUESTSMALL0 | RUSHLARGE0 | SQUADDEATHMATCH0 | TEAMDEATHMATCH0 | DOMINATION0 | ELIMINATION0 | OBLITERATION,

        EXPANSION1 = BASE | AIRSUPERIORITY0,
        EXPANSION2 = BASE | CAPTURETHEFLAG0,
        EXPANSION3 = BASE | CARRIERASSAULTLARGE0 | CARRIERASSAULTSMALL0,
        EXPANSION4 = BASE | CAPTURETHEFLAG0 | CHAINLINK0,
        EXPANSION5 = EXPANSION2, // Stupid, but should be less confusing if someone else reads the code.
        EXPANSION6 = CONQUESTLARGE0 | CONQUESTSMALL0 | DOMINATION0 | OBLITERATION | RUSHLARGE0 | TEAMDEATHMATCH0 | GUNMASTER0 | GUNMASTER1,
        EXPANSION7 = CONQUESTLARGE0 | CONQUESTSMALL0 | DOMINATION0 | OBLITERATION | RUSHLARGE0 | SQUADDEATHMATCH0 | SQUADDEATHMATCH1 | TEAMDEATHMATCH0 | TEAMDEATHMATCH1 | CAPTURETHEFLAG0 | CHAINLINK0 | GUNMASTER0 | GUNMASTER1,
        EXPANSION8 = CONQUESTLARGE0 | CONQUESTSMALL0 | DOMINATION0 | OBLITERATION | RUSHLARGE0 | SQUADDEATHMATCH0 | TEAMDEATHMATCH0 | GUNMASTER0 | AIRSUPERIORITY0
    }

    public class BF4Map : ICloneable
    {
        /// <summary>
        /// A datastructure describing a BF4 Map
        /// </summary>
        public string InternalName;

        public string FriendlyName;

        // public string XPackName; // Expansion Pack Name
        public GameTypes GameTypeList = GameTypes.NONE;

        public int XPack;
        public BF4GameType IntendedGameType = new BF4GameType();

        // Default constructor
        public BF4Map()
        {
        }

        public BF4Map(string iname, string fname, int xp, GameTypes gts)
        {
            InternalName = iname;
            FriendlyName = fname;
            XPack = xp;
            GameTypeList = gts;
        }

        /// <summary>
        /// Clones the object to prevent the Program.BF4Maps reference from being updated
        /// when generating map lists for each game type.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            BF4Map b = new BF4Map();
            b.InternalName = this.InternalName;
            b.FriendlyName = this.FriendlyName;
            b.GameTypeList = this.GameTypeList;
            b.IntendedGameType = this.IntendedGameType;
            return b;
        }
    }

    public class BF4GameType
    {
        /// <summary>
        /// A data structure describing a BF4 Game Type
        /// </summary>
        public string InternalName; // Internal game type name

        public string FriendlyName;
        public int NumPlayers = -1; // Number of players supported by game type - THIS PROPERTY IS NOT USED RIGHT NOW.
        public GameTypes GameType = GameTypes.NONE;

        // Default constructor
        public BF4GameType()
        {
        }

        public BF4GameType(string iname, string fname, int nump, GameTypes gt)
        {
            InternalName = iname;
            FriendlyName = fname;
            NumPlayers = nump;
            GameType = gt;
        }
    }

    public class BF4MapListPerGameType
    {
        /// <summary>
        /// This class describes a map list per game type pattern.
        /// It is populated from the pattern listbox lbGameTypesPattern on MainForm.
        /// </summary>
        ///
        /// This class is instantiated via the MainForm.GenerateList() function.
        public GameTypes GameTypeEnum = GameTypes.NONE; // Gametype of the pattern entry

        public List<BF4Map> Maps = new List<BF4Map>();
        public decimal Rounds = -1;
        public List<BF4Map> UsedMaps = new List<BF4Map>();
        public int UsedMapsCurrentIndex = 0;

        // Default constructor
        public BF4MapListPerGameType()
        {
        }

        public BF4MapListPerGameType(GameTypes gt, decimal r)
        {
            GameTypeEnum = gt;
            Rounds = r;
        }
    }
}