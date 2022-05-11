using System;
using Scripts.Stats;
using Scripts.Units;
using UnityEditor;
using UnityEngine;

namespace Scripts.Editor
{
    [CustomPropertyDrawer(typeof(StatsHandler))]
    public class StatsHandlerDrawer : PropertyDrawer
    {
        private SerializedProperty _stats_list;

        private static string Title => "Stats";
        
        private static int Length => Enum.GetNames(typeof(StatsTypes)).Length;
        
        private static string[] StatsName => Enum.GetNames(typeof(StatsTypes));
        
        
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            _stats_list = property.FindPropertyRelative("_stats");

            ResetStatsLength();
            

            var dimensions = new Vector2(position.width / 2,position.height / (Length + 1)) ;
            
            CreateTitle(position, dimensions);
            
            CreateRows(position, dimensions);
        }
        
        private void ResetStatsLength()
        {
            if (_stats_list.arraySize == Length) return;
            
            _stats_list.ClearArray();

            for (var i = 0; i < Length; i++)
            {
                _stats_list.InsertArrayElementAtIndex(i);
            }
        }
        
        private static void CreateTitle(Rect position, Vector2 dimensions)
        {
            EditorGUI.LabelField(new Rect(position.min, new Vector2(position.width, dimensions.y)), Title);
        }
        
        private void CreateRows(Rect position, Vector2 dimensions)
        {
            for (var i = 0; i < Length; i++)
            {
                var row_position = new Rect(position.min + new Vector2(0, (i + 1) * dimensions.y), dimensions);
                
                EditorGUI.LabelField(row_position, StatsName[i]);

                row_position.center += new Vector2(dimensions.x, 0);

                EditorGUI.PropertyField(row_position, _stats_list.GetArrayElementAtIndex(i), GUIContent.none);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label) * (Length + 1);
        }
    }
}