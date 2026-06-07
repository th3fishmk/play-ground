using UnityEditor;
using UnityEngine;

public class eDtorWindow : EditorWindow
{
    [MenuItem("Tools/eDtorWindow")]
    public static void ShowWindow()
    {
        GetWindow<eDtorWindow>();
    }

    private void OnGUI()
    {
    }
}