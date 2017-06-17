using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(CreatureRaycast))]
	public class CreatureRaycastEditor : Editor
	{
		private CreatureRaycast creatureRaycast;

		private void DisplayFoundationRaycastError ()
		{
			if (creatureRaycast.GetMemberValue("foundationRaycast") == null)
			{
				EditorGUILayout.HelpBox("Foundation Raycast is null. This will cause errors in any Raycasting done with CreatureRaycast.cs. " +
					"Please drag the Foundation Raycast component to the box and then hit apply.", MessageType.Error);
			}
		}

		public override void OnInspectorGUI ()
		{
			base.OnInspectorGUI ();
			creatureRaycast = (CreatureRaycast)target;
			DisplayFoundationRaycastError ();
		}
	}  
}