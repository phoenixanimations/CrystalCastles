using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof (FoundationRaycast))]
	public sealed class FoundationRaycastEditor : Editor
	{
		private FoundationRaycast foundationRaycast;
		private CircleCollider2D circleCollider2D;
		private float x;
		private float y;
		private bool raycastLine;

		/// <summary>
		/// This uses reflection. Its purpose is to display a private variable in the Editor UI.
		/// </summary>
		/// <param name="description">The description of the variable. If "" it will ignore the description.</param>
		/// <param name="floatName">The actual variable name for the float.</param>
		private void displayPrivateFloat (string description, string floatName, params GUILayoutOption[] option)
		{
			float assignValue = (float)foundationRaycast.GetMemberValue(floatName);
			if (description == "")
			{
				assignValue = EditorGUILayout.FloatField(assignValue, option);
			}
			else
			{
				assignValue = EditorGUILayout.FloatField(description, assignValue, option);
			}
			foundationRaycast.SetMemberValue(floatName, assignValue);
		}

		/// <summary>
		/// Displays an error if distance is less than 0.
		/// </summary>
		private void DisplayDistanceError ()
		{
			if (foundationRaycast.distance == 0f)
			{
				EditorGUILayout.HelpBox("Distance is 0, this means anything FoundationPhysics/Raycast related does will not take effect.",MessageType.Warning);
			}
		}

		/// <summary>
		/// Sets the private x,y and serializeDistance through reflection when the button is pressed.
		/// </summary>
		private void SetVariableButton ()
		{
			if (GUILayout.Button("Set Variable", GUILayout.Height(14f), GUILayout.Width(132f)))	
			{
				foundationRaycast.SetMemberValue("x", circleCollider2D.offset.x);
				foundationRaycast.SetMemberValue("y", circleCollider2D.offset.y);
				foundationRaycast.SetMemberValue("serializeDistance", RaycastVariable.distance);
			}
		}
		/// <summary>
		/// Checks if you have a circle collider and if so displays an error if the offset/distance doesn't match.
		/// </summary>
		private void DisplayCircleColliderError ()
		{
			if (circleCollider2D != null)
			{
				if (circleCollider2D.offset.x != x || circleCollider2D.offset.y != y || foundationRaycast.distance != RaycastVariable.distance)
				{
					EditorGUILayout.HelpBox ("Since you attached a circle collider, it would make sense if the raycast stats were equal to the collider. " +
						"As FoundationPhysics.cs and CreaturePhysics.cs need it to be equal to function correctly. You can ignore this if you know what you're doing." +
						"Press the Set Variable button if you don't.", MessageType.Warning);
					SetVariableButton ();
				}	
			}
		}

		public void OnEnable ()
		{
			foundationRaycast = (FoundationRaycast)target;
			circleCollider2D = foundationRaycast.GetComponent <CircleCollider2D>();
		}

		public override void OnInspectorGUI ()
		{
			foundationRaycast = (FoundationRaycast)target;
			x = (float)foundationRaycast.GetMemberValue("x");
			y = (float)foundationRaycast.GetMemberValue("y");

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
			EditorGUILayout.LabelField("Distance",GUILayout.Width(74f));
			displayPrivateFloat("", "serializeDistance", GUILayout.Width(45f));
			EditorGUILayout.EndHorizontal ();

			DisplayCircleColliderError ();
			DisplayDistanceError ();

			if (raycastLine)
			{
				EditorGUILayout.HelpBox("Please note this is a guideline and is not accurate. " +
					"For whatever reason this is not to scale, " +
					"it's just used to see if things are going generally in the right direction.", MessageType.Info);
			}
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
		private void DrawLine()
		{
			float xStart = x + foundationRaycast.transform.position.x;
			float yStart = y + foundationRaycast.transform.position.y;
			float xEnd = xStart + foundationRaycast.distance;
			Vector2 start = new Vector2 (xStart, yStart);
			Vector2 end = new Vector2 (xEnd, yStart);
			Handles.color = Color.red;
			Handles.DrawLine(start, end);
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
