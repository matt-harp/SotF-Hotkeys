using Il2CppTheForest.Utils;
using MelonLoader;
using UnityEngine;

namespace Hotkeys;

public class HotkeyMod : MelonMod
{
    public override void OnInitializeMelon()
    {
        Melon<HotkeyMod>.Logger.Msg("Hotkeys initialized, press 1/2 to access tools bound to your backpack.");
    }

    public override void OnUpdate()
    {
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