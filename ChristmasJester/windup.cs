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
    internal class ChristmasJesterPatchWinup
    {
        [HarmonyPatch(nameof(JesterAI.Start))]
        [HarmonyPrefix]
        public static void ChristmasJesterWind(ref AudioClip ___popGoesTheWeaselTheme)
        {
            ___popGoesTheWeaselTheme = ChristmasJesterBase.newSFX2;
        }
    }
}
