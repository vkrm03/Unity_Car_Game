#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class Startup
{
    static Startup()    
    {
        EditorPrefs.SetInt("showCounts_sportcarcr3", EditorPrefs.GetInt("showCounts_sportcarcr3") + 1);

        if (EditorPrefs.GetInt("showCounts_sportcarcr3") == 1)       
        {
            Application.OpenURL("https://assetstore.unity.com/packages/templates/packs/complete-racing-game-all-in-one-324985");
            // System.IO.File.Delete("Assets/SportCar/Racing_Game.cs");
        }
    }     
}
#endif
