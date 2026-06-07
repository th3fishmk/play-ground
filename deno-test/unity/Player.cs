using UnityEditor;

[CustomEditor(typeof(TargetType))]
public class Player : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }
}