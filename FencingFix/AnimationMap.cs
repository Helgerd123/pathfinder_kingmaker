// Copyright (c) 2021 Helgerd123
// This code is licensed under MIT license (see LICENSE for details)

using Kingmaker.View.Animation;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FencingFix
{
    internal class AnimationMap
    {
        public AnimationMap(string settingsFile)
        {
            JsonSerializer serializer = new JsonSerializer();
            using StreamReader file = File.OpenText(settingsFile);
            using JsonReader reader = new JsonTextReader(file);
            Map = serializer.Deserialize<Dictionary<WeaponAnimationStyle, WeaponAnimationStyle>>(reader);
        }

        public WeaponAnimationStyle this[WeaponAnimationStyle index]
        {
            get => Map.TryGetValue(index, out WeaponAnimationStyle result) ? result : WeaponAnimationStyle.None;
        }

        private Dictionary<WeaponAnimationStyle, WeaponAnimationStyle> Map { get; }
    }
}
