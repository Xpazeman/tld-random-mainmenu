using System.Reflection;
using System;
using Harmony;
using UnityEngine;
using MelonLoader;

namespace RandomMainMenu
{
    internal class RandomMainMenu : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log("[random-main-menu] Version " + Assembly.GetExecutingAssembly().GetName().Version);
        }
    }

    [HarmonyPatch(typeof(Panel_MainMenu), "Start")]
    internal class Panel_MainMenu_Start
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
