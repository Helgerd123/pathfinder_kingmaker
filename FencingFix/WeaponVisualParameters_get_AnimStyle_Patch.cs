// Copyright (c) 2021 Helgerd123
// This code is licensed under MIT license (see LICENSE for details)

using Harmony12;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.View.Animation;

namespace FencingFix
{
    [HarmonyPatch(typeof(WeaponVisualParameters), "get_AnimStyle")]
    internal static class WeaponVisualParameters_get_AnimStyle_Patch
    {
        private static void Postfix(ref WeaponAnimationStyle __result)
        {
            var mappedAnimation = Main.AnimationMap[__result];

            if (mappedAnimation != WeaponAnimationStyle.None)
            {
                __result = mappedAnimation;
            }
        }
    }
}