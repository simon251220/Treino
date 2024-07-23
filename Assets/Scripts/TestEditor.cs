using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Test))]
public class TestEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Test test = (Test)target;

        
        base.OnInspectorGUI();

        if (GUILayout.Button("Print Hello"))
        {
            test.PrintHello();
        }
    }
}
