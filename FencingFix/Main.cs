// Copyright (c) Helgerd123
// This code is licensed under MIT license (see LICENSE for details)

using Harmony12;
using System.Reflection;
using UnityModManagerNet;

namespace FencingFix
{
    public class Main
    {
        public static bool enabled;

        public static UnityModManager.ModEntry.ModLogger logger;

        internal static AnimationMap AnimationMap;

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            modEntry.OnToggle = OnToggle;
            AnimationMap = new AnimationMap("Mods/FencingFix/animation_map.json");

            var harmonyInstance = HarmonyInstance.Create(modEntry.Info.Id);
            harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());

            return true;
        }

        private static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            enabled = value;
            return true;
        }
    }
}