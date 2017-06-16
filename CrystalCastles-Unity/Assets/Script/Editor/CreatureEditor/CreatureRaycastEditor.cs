using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(CreatureRaycast))]
	public class CreatureRaycastEditor : Editor
	{
		private CreatureRaycast creatureRaycast;
		private bool raycastLine;
		/// <summary>
		/// This uses reflection. Its purpose is to display a private variable in the Editor UI.
		/// </summary>
		/// <param name="description">The description of the variable. If "" it will ignore the description.</param>
		/// <param name="floatName">The actual variable name for the float.</param>
		/// It is possible I don't need to do this because of Unity's Serialized Field property.
		private void displayPrivateFloat (string description, string floatName, params GUILayoutOption[] option)
		{
			float assignValue = (float)creatureRaycast.GetMemberValue(floatName);
			if (description == "")
			{
				assignValue = EditorGUILayout.FloatField(assignValue, option);
			}
			else
			{
				assignValue = EditorGUILayout.FloatField(description, assignValue, option);
			}
			creatureRaycast.SetMemberValue(floatName, assignValue);
		}

		/// <summary>
		/// Draws a line to show how long a raycast would go. Please note this is a guideline that isn't accurate.
		/// For whatever reason this is not to scale exactly, it's just used to see if things are going generally in the
		/// right direction.
		/// </summary>
		/// DrawLine works with points, the the x/yStart values as the first dot, and the
		/// x/yEnd values as the second. Making yEnd = yStart will make it so the line is 
		/// always horizontal. This is to avoid math, as the actual raycast casts a ray like a graph 
		/// not a line.
		void DrawLine()
		{
			float xStart = (float)creatureRaycast.GetMemberValue("x");
			float yStart = (float)creatureRaycast.GetMemberValue("y");
			float xEnd = xStart + creatureRaycast.length;
			float yEnd = yStart;
			Vector2 start = new Vector2 (xStart, yStart);
			Vector2 end = new Vector2 (xEnd, yEnd);
			Handles.color = Color.red;
			Handles.DrawLine(start, end);
		}

		public override void OnInspectorGUI ()
		{
			creatureRaycast = (CreatureRaycast)target;

			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.LabelField("Location",GUILayout.Width(60f));

			EditorGUILayout.LabelField("x", GUILayout.Width(10f));
			displayPrivateFloat("", "x", GUILayout.Width(45f));

			EditorGUILayout.LabelField("y", GUILayout.Width(10f));
			displayPrivateFloat("", "y", GUILayout.Width(45f));

			raycastLine = EditorGUILayout.Toggle(raycastLine,GUILayout.Width(11f));
			EditorGUILayout.LabelField("Show",GUILayout.Width(40f));
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal ();
			EditorGUILayout.LabelField("Length",GUILayout.Width(74f));
			displayPrivateFloat("", "serializeLength", GUILayout.Width(45f));
			EditorGUILayout.EndHorizontal ();

			if (raycastLine)
			{
				EditorGUILayout.HelpBox("Please note this is a guideline and is not accurate. " +
					"For whatever reason this is not to scale, " +
					"it's just used to see if things are going generally in the right direction.", MessageType.Info);
			}
		}

		public void OnSceneGUI() 
		{
			if (raycastLine)
			{
				DrawLine();
			}
			SceneView.RepaintAll(); 
		}
	}  
}