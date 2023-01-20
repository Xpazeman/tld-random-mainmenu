using System.Reflection;
using System;
using HarmonyLib;
using UnityEngine;
using MelonLoader;
using Il2Cpp;

namespace RandomMainMenu
{
    internal class RandomMainMenu : MelonMod
    {
        public override void OnInitializeMelon()
        {
            
        }
    }

    [HarmonyPatch(typeof(Panel_MainMenu), "Initialize")]
    internal class Panel_MainMenu_Initialize
    {
        public static void Postfix(Panel_MainMenu __instance)
        {
            StartSettings set = __instance.m_StartSettings;
            set.m_RandomTimeOfDay = true;
            set.m_RandomWeather = true;
            __instance.m_StartSettings = set;
        }
    }
}
