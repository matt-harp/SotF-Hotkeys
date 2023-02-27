using System.Reflection;
using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace Hotkeys;

[BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public const string PLUGIN_GUID = "Night.Hotkeys";
    public const string PLUGIN_NAME = "Hotkeys";
    public const string PLUGIN_VERSION = "1.0.1";

    public override void Load()
    {
        var harmony = new Harmony(PLUGIN_GUID);
        harmony.PatchAll(Assembly.GetExecutingAssembly());
        
        Log.LogInfo($"{PLUGIN_NAME} is loaded!");
    }
}
