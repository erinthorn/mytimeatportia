﻿using Harmony12;
using System;

namespace MarriageMod
{
    public static partial class Main
    {
        [HarmonyPatch(typeof(Pathea.Player), "InteractiveJealousStart", new Type[] { })]
        static class Pathea_Player_InteractiveJealousStart_Patch
        {
            static bool Prefix()
            {
                if (!Main.enabled)
                    return true;
                Dbgl("Pathea_Player_InteractiveJealous_Patch");

                return false;
            }
        }
    }
}