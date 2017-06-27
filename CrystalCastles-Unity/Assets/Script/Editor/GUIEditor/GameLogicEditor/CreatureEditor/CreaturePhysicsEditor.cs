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

		private void DisplayFoundationPhysicsError ()
		{
			if (creaturePhysics.GetMemberValue("creatureRaycast") == null)
			{
				EditorGUILayout.HelpBox(HelpBox.ComponentError("Creature Raycast"), MessageType.Error);
			}

			if (creaturePhysics.GetMemberValue("foundationPhysics") == null)
			{
				EditorGUILayout.HelpBox(HelpBox.ComponentError("Foundation Physics"), MessageType.Error);
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
