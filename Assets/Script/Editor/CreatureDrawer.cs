using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//CreatureDrawer
[CustomPropertyDrawer(typeof(CreatureCard))]
public class CreatureDrawer : PropertyDrawer 
{
    // Draw the property inside the given rect
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Using BeginProperty / EndProperty on the parent property means that
        // prefab override logic works on the entire property.
        EditorGUI.BeginProperty(position, label, property);

        // Don't make child fields be indented
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        EditorGUIUtility.labelWidth = 50;

        // Calculate rects
        var damageRect = new Rect(position.x, position.y, 100, position.height);
        var costRect = new Rect(position.x + 105, position.y, 100, position.height);
        var nameRect = new Rect(position.x + 210, position.y, position.width - 210, position.height);

        // Draw fields - passs GUIContent.none to each so they are drawn without labels
        EditorGUI.PropertyField(damageRect, property.FindPropertyRelative("CreatureInfo.Damage"), new GUIContent("Damage"));
        EditorGUI.PropertyField(costRect, property.FindPropertyRelative("CardInfo.ElixirCost") , new GUIContent("Elixir"));
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("CardInfo.Name"), new GUIContent("Name"));

        // Set indent back to what it was
        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}
