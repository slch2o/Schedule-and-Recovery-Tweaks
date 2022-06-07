using BokuMono;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysFirstMod.Harmony_Patches
{

    [HarmonyPatch(typeof(GameController), nameof(GameController.Init))]
    internal class GameController_Init
    {
        [HarmonyPrefix]
        internal static bool Prefix(GameController __instance)
        {
            return true;
        }

        [HarmonyPostfix]
        internal static void Postfix(GameController __instance)
        {
            //This makes the bath heal 500 "HP"
            __instance.GameSetting.HealValueOfBath = 500;
            //The hour is the only thing that can be messed with, so in the interest of not making fainting completely obsolete, this is set to 5.
            //Currently, I can't get this feature to work. Hopefully in a future version!
            //__instance.GameSetting.PlayerTimeToFaintHour = 5;
        }
    }
}
