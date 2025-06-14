using HarmonyLib;
using Hospitality.Utilities;
using Verse;

namespace Hospitality.Patches;

/// <summary>
/// So guests don't birth children during their visit
/// </summary>
public class Hediff_Pregnant_Patch
{
    [HarmonyPatch(typeof(Hediff_Pregnant), nameof(Hediff_Pregnant.TickInterval))]
    public static class Hediff_Pregnant_TickInterval_Patch
    {
        [HarmonyPrefix]
        public static bool Prefix(ref Hediff_Pregnant __instance)
        {
            return __instance?.pawn?.IsGuest() != true;
        }
    }
}