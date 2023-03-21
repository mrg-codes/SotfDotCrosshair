using BepInEx;
using UnityEngine;
using Il2CppInterop.Runtime.Injection;
using BepInEx.Unity.IL2CPP;
using BepInEx.Unity.IL2CPP.UnityEngine;
using System.IO;

namespace SotfDotCrosshair
{
    [BepInPlugin(GUID, MODNAME, VERSION)]
    [BepInProcess("sonsoftheforest.exe")]
    public class SotfDotCrosshair : BasePlugin
    {

        public const string
            MODNAME = "SotfDotCrosshair",
            AUTHOR = "Aprox",
            GUID = MODNAME + "_by_" + AUTHOR,
            VERSION = "1.0.0";
        public override void Load()
        {

            // Create and inject new game object
            ClassInjector.RegisterTypeInIl2Cpp<CustomComponent>();
            var go = new GameObject("CustomGameObject") { hideFlags = HideFlags.HideAndDontSave };
            go.AddComponent<CustomComponent>();
            GameObject.DontDestroyOnLoad(go);

            Log.LogInfo("Plugin " + GUID + " v" + VERSION + "is loaded!");

        }
    }
    public class CustomComponent : MonoBehaviour
    {
        private void Start()
        {
            // Execute this code when game starts (or when object is created)
        }

        private void Update()
        {
            // Execute this code every frame

            // Check for key input (UnityEngine.InputLegacy)
            if (UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Keypad1))
            {
                // Do something
            }
        }

        private void FixedUpdate()
        {
            // Execute this code every synced frame (50 times per second)
        }
    }
}
