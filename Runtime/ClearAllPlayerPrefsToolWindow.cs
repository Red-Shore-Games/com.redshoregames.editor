#if UNITY_EDITOR
using RedShoreGames.Utils;
using UnityEditor;
using UnityEngine;

namespace RedShoreGames.Editor
{
    public class ClearAllPlayerPrefsToolWindow : MonoBehaviour
    {
        [MenuItem("Red Shore Games/Clear All Player Prefs", false, 0)]
        public static void ClearAllPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
            RSGDebug.Log("<color=orange> <color=green>Success : </color>All Player Prefs Cleared!</color>");
        }
    }
}
#endif