using BokuMono;
using BokuMono.Data;
using BokuMono.Utility;
using HarmonyLib;
using HarmonyLib.Tools;
using Il2CppSystem;
using Il2CppSystem.Globalization;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.PlayerLoop;

namespace ModTemplate.Harmony_Patches
{
	[HarmonyPatch(typeof(PlayerRecoveryMasterData), nameof(PlayerRecoveryMasterData.GetRecoveryRate))]
	class Patch
    {
        static void Postfix(PlayerRecoveryMasterData __instance)
        {
            //This changes the time that the player wakes up to 6:00 AM, regardless of when they went to sleep. 
            __instance.WakeUpTime = "6:00";
        }
	}
}
