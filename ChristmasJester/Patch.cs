using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ChristmasJester
{
    [HarmonyPatch(typeof(JesterAI))]
    internal class ChristmasJesterPatch
    {
        [HarmonyPatch(nameof(JesterAI.Start))]
        [HarmonyPrefix]
        public static void ChristmasJesterPop(ref AudioClip ___screamingSFX)
        {
            ___screamingSFX = ChristmasJesterBase.newSFX;
        }

    }
}
