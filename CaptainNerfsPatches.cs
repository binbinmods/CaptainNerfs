using BepInEx;
using BepInEx.Logging;
using BepInEx.Configuration;
using HarmonyLib;
// using static Obeliskial_Essentials.Essentials;
using System;
using static CaptainNerfs.Plugin;
using static CaptainNerfs.CustomFunctions;
using static CaptainNerfs.CaptainNerfsFunctions;
using System.Collections.Generic;
using static Functions;
using UnityEngine;
// using Photon.Pun;
using TMPro;
using System.Linq;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Reflection;
using UnityEngine.UIElements;
// using Unity.TextMeshPro;

// Make sure your namespace is the same everywhere
namespace CaptainNerfs
{

    [HarmonyPatch] // DO NOT REMOVE/CHANGE - This tells your plugin that this is part of the mod

    public class CaptainNerfsPatches
    {



        // [HarmonyPrefix]
        // [HarmonyPatch(typeof(AtOManager), "GetExperienceFromCombat")]
        // public static bool GetExperienceFromCombatPrefix(ref int __result, ref AtOManager __instance)
        // {
        //     int experienceFromCombat = 0;
        //     string[] teamNPCAtO = __instance.GetTeamNPC();
        //     if (teamNPCAtO != null)
        //     {
        //         for (int index = 0; index < teamNPCAtO.Length; ++index)
        //         {
        //             if (teamNPCAtO[index] != null && teamNPCAtO[index] != "")
        //             {
        //                 NPCData npcData = Globals.Instance.GetNPC(teamNPCAtO[index]);
        //                 if (npcData != null)
        //                 {
        //                     if ((UnityEngine.Object)npcData != (UnityEngine.Object)null && __instance.PlayerHasRequirement(Globals.Instance.GetRequirementData("_tier2")) && (UnityEngine.Object)npcData.UpgradedMob != (UnityEngine.Object)null)
        //                         npcData = npcData.UpgradedMob;
        //                     if ((UnityEngine.Object)npcData != (UnityEngine.Object)null && __instance.GetNgPlus() > 0 && npcData.NgPlusMob != null)
        //                         npcData = npcData.NgPlusMob;
        //                     if (npcData != null && MadnessManager.Instance.IsMadnessTraitActive("despair") && (UnityEngine.Object)npcData.HellModeMob != (UnityEngine.Object)null)
        //                         npcData = npcData.HellModeMob;
        //                     if ((UnityEngine.Object)npcData != (UnityEngine.Object)null && npcData.ExperienceReward > 0)
        //                         experienceFromCombat += npcData.ExperienceReward;
        //                 }
        //             }
        //         }
        //     }
        //     __result = experienceFromCombat;
        //     return false; // do not run original method
        // }

        // [HarmonyPrefix]
        // [HarmonyPatch(typeof(AtOManager), "GetGoldFromCombat")]
        // public static bool GetGoldFromCombatPrefix(ref int __result, ref AtOManager __instance)
        // {
        //     int goldFromCombat = 0;
        //     string[] teamNPCAtO = __instance.GetTeamNPC();
        //     if (teamNPCAtO != null)
        //     {
        //         for (int index = 0; index < teamNPCAtO.Length; ++index)
        //         {
        //             if (teamNPCAtO[index] != null && teamNPCAtO[index] != "")
        //             {
        //                 NPCData npcData = Globals.Instance.GetNPC(teamNPCAtO[index]);
        //                 if (npcData != null)
        //                 {
        //                     if ((UnityEngine.Object)npcData != (UnityEngine.Object)null && __instance.PlayerHasRequirement(Globals.Instance.GetRequirementData("_tier2")) && (UnityEngine.Object)npcData.UpgradedMob != (UnityEngine.Object)null)
        //                         npcData = npcData.UpgradedMob;
        //                     if ((UnityEngine.Object)npcData != (UnityEngine.Object)null && __instance.GetNgPlus() > 0 && npcData.NgPlusMob != null)
        //                         npcData = npcData.NgPlusMob;
        //                     if (npcData != null && MadnessManager.Instance.IsMadnessTraitActive("despair") && (UnityEngine.Object)npcData.HellModeMob != (UnityEngine.Object)null)
        //                         npcData = npcData.HellModeMob;
        //                     if ((UnityEngine.Object)npcData != (UnityEngine.Object)null && npcData.GoldReward > 0)
        //                         goldFromCombat += npcData.GoldReward;
        //                 }
        //             }
        //         }
        //     }
        //     __result = goldFromCombat;
        //     return false; // do not run original method
        // }



        // [HarmonyPrefix]
        // [HarmonyPatch(typeof(SteamManager), "SetObeliskScore")]
        // public static bool SetObeliskScorePrefix(ref SteamManager __instance, int score, bool singleplayer = true)
        // {
        //     return false;
        // }

        // [HarmonyPrefix]
        // [HarmonyPatch(typeof(SteamManager), "SetScore")]
        // public static bool SetScorePrefix(ref SteamManager __instance, int score, bool singleplayer = true)
        // {
        //     return false;
        // }

        // [HarmonyPrefix]
        // [HarmonyPatch(typeof(SteamManager), "SetSingularityScore")]
        // public static bool SetSingularityScorePrefix(ref SteamManager __instance, int score, bool singleplayer = true)
        // {
        //     return false;
        // }

        // [HarmonyPrefix]
        // [HarmonyPatch(typeof(SteamManager), "SetObeliskScoreLeaderboard")]
        // public static bool SetObeliskScoreLeaderboardPrefix(ref SteamManager __instance, int score, bool singleplayer = true)
        // {
        //     return false;
        // }

        // [HarmonyPrefix]
        // [HarmonyPatch(typeof(SteamManager), "SetScoreLeaderboard")]
        // public static bool SetScoreLeaderboardPrefix(ref SteamManager __instance, int score, bool singleplayer = true)
        // {
        //     return false;
        // }

        // [HarmonyPrefix]
        // [HarmonyPatch(typeof(SteamManager), "SetSingularityScoreLeaderboard")]
        // public static bool SetSingularityScoreLeaderboardPrefix(ref SteamManager __instance, int score, bool singleplayer = true)
        // {
        //     return false;
        // }



    }
}