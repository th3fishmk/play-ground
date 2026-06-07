using UnityEditor;

[CustomEditor(typeof(TargetType))]
public class EditorW : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
    }
}