using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(Spin))]
public class SpinDrawer : PropertyDrawer
{
    public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
    {
		EditorGUI.PropertyField(position, property.FindPropertyRelative("value"), label);
	}
}
