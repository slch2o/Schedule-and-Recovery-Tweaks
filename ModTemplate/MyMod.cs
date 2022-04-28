using BokuMono;
using MelonLoader;
using ModTemplate;
using PootModHelper.Api;

// This info is needed to register your mod with MelonLoader. You can ignore it.
[assembly: MelonInfo(typeof(MyMod), MyMod.modName, MyMod.modVersion, MyMod.modAuthor)]
[assembly: MelonGame("XSEED Games _ Marvelous USA, Inc.", "STORY OF SEASONS Pioneers of Olive Town")]

namespace ModTemplate
{
    public class MyMod : PootMod
    {
        public static MelonLogger.Instance Logger { get; private set; }
        
        public const string modName = "Mod Template";
        public const string modVersion = "1.0.0.0";
        public const string modAuthor = "Gurrenm4";

        /// <summary>
        /// This code runs automatically as soon as the mod is registered by MelonLoader.
        /// </summary>
        public override void OnApplicationStart()
        {
            // <-- Ignore this code --> //
            Logger = LoggerInstance;
            base.OnApplicationStart();


            // <-- Your code goes below here --> //
            
        }

        public override void OnMainMenu()
        {
            // this is an example of using Mod Helper events.
            // For this event, any code in here will automatically run when Main Menu is shown.
        }
    }
}
