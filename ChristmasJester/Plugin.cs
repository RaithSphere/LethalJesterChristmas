using LCSoundTool;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using System.IO;

namespace ChristmasJester
{
    [BepInPlugin(modGUID, modName, modVersion)]
    [BepInDependency("LCSoundTool")]
    public class ChristmasJesterBase : BaseUnityPlugin
    {
        private const string modGUID     = "RaithSphere.ChristmasJester";
        private const string modName     = "Christmas Jester";
        private const string modVersion  = "1.0.2";

        internal ManualLogSource mls;
        internal static AudioClip newSFX;
        internal static AudioClip newSFX2;

        private readonly Harmony harmony = new Harmony(modGUID);

        private static ChristmasJesterBase _instance;

        void Awake()
        {
            if (_instance == null) _instance = this;
            Logger.Log(LogLevel.Info, "Defrosting");

            newSFX = SoundTool.GetAudioClip(Path.GetDirectoryName(_instance.Info.Location), "christmas.wav");
            newSFX2 = SoundTool.GetAudioClip(Path.GetDirectoryName(_instance.Info.Location), "christmas2.wav");

            harmony.PatchAll(typeof(ChristmasJesterBase));
            harmony.PatchAll(typeof(ChristmasJesterPatch));
            harmony.PatchAll(typeof(ChristmasJesterPatchWinup));
        }

    }
}
