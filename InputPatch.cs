using HarmonyLib;
using Sons.Input;
using TheForest.Utils;
using UnityEngine;

namespace Hotkeys;

[HarmonyPatch]
public class InputPatch
{
    [HarmonyPatch(typeof(InputEventsManager), "Update")]
    [HarmonyPostfix]
    static void Update()
    {
        if (LocalPlayer._instance == null) return;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LocalPlayer.Inventory.TryEquip(LocalPlayer.Inventory._quickSlots._items[0]._itemId, false, false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            LocalPlayer.Inventory.TryEquip(LocalPlayer.Inventory._quickSlots._items[1]._itemId, false, false);
        }
    }
}