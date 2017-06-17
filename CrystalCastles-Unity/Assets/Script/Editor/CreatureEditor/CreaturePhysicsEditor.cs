using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(CreaturePhysics))]
	public class CreaturePhysicsEditor : Editor
	{
		private CreaturePhysics creaturePhysics;

		private string ComponentError (string componentName)
		{
			return componentName + " is null. This will cause errors with the code. " +
				"Please drag the " + componentName + " component to the box and then hit apply.";
		}

		private void DisplayFoundationPhysicsError ()
		{
			if (creaturePhysics.GetMemberValue("creatureRaycast") == null)
			{
				EditorGUILayout.HelpBox(ComponentError("Creature Raycast"), MessageType.Error);
			}

			if (creaturePhysics.GetMemberValue("foundationPhysics") == null)
			{
				EditorGUILayout.HelpBox(ComponentError("Foundation Physics"), MessageType.Error);
			}
		}

		public override void OnInspectorGUI ()
		{
			base.OnInspectorGUI ();
			creaturePhysics = (CreaturePhysics)target;
			DisplayFoundationPhysicsError ();
		}
	}
}
