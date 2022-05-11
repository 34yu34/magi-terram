using Scripts.Stats;
using UnityEditor;
using UnityEngine;

namespace Scripts.Editor
{
    [CustomPropertyDrawer(typeof(Stat))]
    public class StatDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property,
            GUIContent label)
        {
            var base_val = property.FindPropertyRelative("_base_value");
            EditorGUI.PropertyField(position, base_val, label);
            
            var curr = property.FindPropertyRelative("_current_value");

            curr.floatValue = base_val.floatValue;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label);
        }
    }
}