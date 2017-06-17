using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(FoundationPhysics))]
	public class FoundationPhysicsEditor : Editor
	{
		private FoundationPhysics foundationPhysics;//change to foundation

		/// <summary>
		/// This creates a button in the custom inspector, that when clicked assigns the FoundationRaycast to FoundationPhysics.
		/// </summary>
		private void ErrorButton ()
		{
			if (GUILayout.Button ("Set FoundationRaycast", GUILayout.Height (14f), GUILayout.Width (132f)))
			{
				foundationPhysics.SetMemberValue("foundationRaycast", foundationPhysics.GetComponent<FoundationRaycast> ());
			}
		}

		/// <summary>
		/// Displays an error if you don't have the component attached to the physics.
		/// </summary>
		private void DisplayFoundationPhysicsError ()
		{
			if (foundationPhysics.GetMemberValue("foundationRaycast") == null)
			{
				EditorGUILayout.HelpBox("CreatureRaycast is not assigned. This will cause errors when using Physics. Click the button to avoid errors.", MessageType.Error);
				ErrorButton ();
			}
		}

		public override void OnInspectorGUI ()
		{
			foundationPhysics = (FoundationPhysics)target;
			EditorGUILayout.ObjectField("Foundation Raycast", (FoundationRaycast)foundationPhysics.GetMemberValue("foundationRaycast"), typeof(FoundationRaycast), false);
			DisplayFoundationPhysicsError();
		}
	}
}
