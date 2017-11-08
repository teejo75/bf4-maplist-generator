using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BF4MapListGenerator
{
    public static class Program
    {
        #region PROGRAM_STARTUP_CODE

        /// <summary>
        /// Populates a list of class BF4GameType with game type data
        /// </summary>
        ///
        private const int XPACK_VANILLA = 0, XPACK_1 = 1, XPACK_2 = 2, XPACK_3 = 3, XPACK_4 = 4, XPACK_5 = 5, XPACK_6 = 6, XPACK_7 = 7, XPACK_8 = 8;

        public static string[] BF4XPack = { "Vanilla", "China Rising", "Second Assault", "Naval Strike", "Dragon's Teeth", "Final Stand", "Night Map", "Community Map", "Dragon Valley" };

        public static List<BF4GameType> bf4GameTypes = new List<BF4GameType>() {
            new BF4GameType( "ConquestLarge0","Conquest Large",64, GameTypes.CONQUESTLARGE0 ),
            new BF4GameType( "ConquestSmall0","Conquest Small",32, GameTypes.CONQUESTSMALL0 ),
            new BF4GameType( "RushLarge0","Rush",32, GameTypes.RUSHLARGE0 ),
            new BF4GameType( "SquadDeathMatch0","Squad Deathmatch",16, GameTypes.SQUADDEATHMATCH0 ),
            new BF4GameType( "TeamDeathMatch0","Team Deathmatch",24, GameTypes.TEAMDEATHMATCH0 ),
            new BF4GameType( "Domination0","Domination",20,GameTypes.DOMINATION0 ),
            new BF4GameType( "AirSuperiority0", "Air Superiority",24,GameTypes.AIRSUPERIORITY0 ),
            new BF4GameType( "CaptureTheFlag0", "Capture The Flag",32,GameTypes.CAPTURETHEFLAG0 ),
            new BF4GameType( "Elimination0", "Defuse", 10,GameTypes.ELIMINATION0 ),
            new BF4GameType( "Obliteration", "Obliteration", 32, GameTypes.OBLITERATION),
            new BF4GameType( "CarrierAssaultLarge0", "Carrier Assault Large", 64, GameTypes.CARRIERASSAULTLARGE0),
            new BF4GameType( "CarrierAssaultSmall0", "Carrier Assault Small", 32, GameTypes.CARRIERASSAULTSMALL0),
            new BF4GameType( "Chainlink0", "Chain Link", 32, GameTypes.CHAINLINK0),
            new BF4GameType( "SquadObliteration0", "Squad Obliteration", 16, GameTypes.SQUADOBLITERATION0),
            new BF4GameType( "GunMaster0", "Gun Master", 16, GameTypes.GUNMASTER0),
            new BF4GameType( "GunMaster1", "Gun Master v2", 16, GameTypes.GUNMASTER1),
            new BF4GameType( "SquadDeathMatch1", "Squad Deathmatch v2", 8, GameTypes.SQUADDEATHMATCH1),
            new BF4GameType( "TeamDeathMatch1", "Team Deathmatch v2", 16, GameTypes.TEAMDEATHMATCH1)
            };

        /// <summary>
        /// Populates a list of class BF3Map with map data
        /// </summary>
        public static List<BF4Map> bf4Maps = new List<BF4Map>()
        {
            // Constructor Internal Name, Friendly Name, Expansion Pack, Game Types enum
            new BF4Map( "MP_Abandoned","Zavod 311",XPACK_VANILLA,GameTypes.BASE | GameTypes.SQUADOBLITERATION0 | GameTypes.GUNMASTER0),
            new BF4Map( "MP_Damage","Lancang Dam",XPACK_VANILLA,GameTypes.BASE | GameTypes.GUNMASTER0),
            new BF4Map( "MP_Flooded","Flood Zone",XPACK_VANILLA,GameTypes.BASE | GameTypes.GUNMASTER0),
            new BF4Map( "MP_Journey","Golmud Railway",XPACK_VANILLA,GameTypes.BASE | GameTypes.SQUADOBLITERATION0 | GameTypes.GUNMASTER0),
            new BF4Map( "MP_Naval",	"Paracel Storm",XPACK_VANILLA,GameTypes.BASE | GameTypes.SQUADOBLITERATION0 | GameTypes.GUNMASTER0),
            new BF4Map( "MP_Prison","Operation Locker",XPACK_VANILLA,GameTypes.BASE | GameTypes.SQUADOBLITERATION0 | GameTypes.GUNMASTER0),
            new BF4Map( "MP_Resort","Hainan Resort",XPACK_VANILLA,GameTypes.BASE | GameTypes.SQUADOBLITERATION0 | GameTypes.GUNMASTER0),
            new BF4Map( "MP_Siege","Siege of Shanghai",XPACK_VANILLA,GameTypes.BASE | GameTypes.SQUADOBLITERATION0 | GameTypes.GUNMASTER0),
            new BF4Map( "MP_TheDish","Rogue Transmission",XPACK_VANILLA,GameTypes.BASE | GameTypes.GUNMASTER0),
            new BF4Map( "MP_Tremors","Dawnbreaker",XPACK_VANILLA,GameTypes.BASE | GameTypes.SQUADOBLITERATION0 | GameTypes.GUNMASTER0),
            new BF4Map( "XP1_001","Silk Road",XPACK_1,GameTypes.EXPANSION1),
            new BF4Map( "XP1_002","Altai Range",XPACK_1,GameTypes.EXPANSION1),
            new BF4Map( "XP1_003","Guilin Peaks",XPACK_1,GameTypes.EXPANSION1),
            new BF4Map( "XP1_004","Dragon Pass",XPACK_1,GameTypes.EXPANSION1),
            new BF4Map( "XP0_Caspian","Caspian Border 2014",XPACK_2,GameTypes.EXPANSION2),
            new BF4Map( "XP0_Firestorm","Operation Firestorm 2014",XPACK_2,GameTypes.EXPANSION2),
            new BF4Map( "XP0_Metro","Operation Metro 2014",XPACK_2,GameTypes.EXPANSION2),
            new BF4Map( "XP0_Oman","Gulf of Oman 2014",XPACK_2,GameTypes.EXPANSION2),
            new BF4Map( "XP2_001","Lost Islands",XPACK_3,GameTypes.EXPANSION3),
            new BF4Map( "XP2_002","Nansha Strike",XPACK_3,GameTypes.EXPANSION3),
            new BF4Map( "XP2_003", "Wavebreaker",XPACK_3,GameTypes.EXPANSION3),
            new BF4Map( "XP2_004", "Operation Mortar",XPACK_3,GameTypes.EXPANSION3),
            new BF4Map( "XP3_MarketPl", "Pearl Market", XPACK_4, GameTypes.EXPANSION4),
            new BF4Map( "XP3_Prpganda", "Propaganda", XPACK_4, GameTypes.EXPANSION4),
            new BF4Map( "XP3_UrbanGdn", "Lumphini Garden", XPACK_4, GameTypes.EXPANSION4),
            new BF4Map( "XP3_WtrFront", "Sunken Dragon", XPACK_4, GameTypes.EXPANSION4),
            new BF4Map( "XP4_Arctic", "Operation Whiteout", XPACK_5, GameTypes.EXPANSION5),
            new BF4Map( "XP4_SubBase", "Hammerhead", XPACK_5, GameTypes.EXPANSION5),
            new BF4Map( "XP4_Titan", "Giants Of Karelia", XPACK_5, GameTypes.EXPANSION5),
            new BF4Map( "XP4_Wlkrftry", "Hangar 21", XPACK_5, GameTypes.EXPANSION5),
            new BF4Map( "XP5_Night_01", "Zavod:Graveyard Shift", XPACK_6, GameTypes.EXPANSION6),
            new BF4Map( "XP6_CMP", "Community Map", XPACK_7, GameTypes.EXPANSION7),
            new BF4Map( "XP7_Valley", "Dragon Valley 2015", XPACK_8, GameTypes.EXPANSION8)
        };

        public static BF4Map SelectMap(List<BF4Map> maps, int rndindex)
        {
            BF4Map selectedMap = null;
            return selectedMap = maps[rndindex];
        }

        #endregion PROGRAM_STARTUP_CODE

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}