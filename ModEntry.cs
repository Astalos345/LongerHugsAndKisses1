using StardewModdingAPI;
using StardewModdingAPI.Utilities;
using StardewValley;
using HarmonyLib;
using System.Threading.Tasks;

namespace LongerHugsAndKisses
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            var harmony = new Harmony(this.ModManifest.UniqueID);
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(Farmer))]
    [HarmonyPatch("hugSpouse")]
    public class HugPatch
    {
        public static async void Postfix(Farmer __instance)
        {
            await Task.Delay(5000); // 5 secondes
        }
    }

    [HarmonyPatch(typeof(Farmer))]
    [HarmonyPatch("kissSpouse")]
    public class KissPatch
    {
        public static async void Postfix(Farmer __instance)
        {
            await Task.Delay(3000); // 3 secondes
        }
    }
}
