using BokuMono.Data;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTemplate.Harmony_Patches
{

    [HarmonyPatch(typeof(PlayerRecoveryMasterData), nameof(PlayerRecoveryMasterData.IsMatchTime))]
    internal class PlayerRecoveryMasterData_IsMatchTime
    {
        [HarmonyPostfix]
        internal static void Postfix(PlayerRecoveryMasterData __instance)
        {
            //This table changes the amount that a character recovers based on when they go to sleep. Hop on the Discord if you want details!
            switch (__instance.Id)
            {
                case 1:
                    __instance.PerHourRate = 15;
                    break;
                case 2:
                    __instance.PerHourRate = 12;
                    break;
                case 3:
                    __instance.PerHourRate = 10;
                    break;
                case 4:
                    __instance.PerHourRate = 9;
                    break;
                case 5:
                    __instance.PerHourRate = 8;
                    break;
            }
        }
    }
}
