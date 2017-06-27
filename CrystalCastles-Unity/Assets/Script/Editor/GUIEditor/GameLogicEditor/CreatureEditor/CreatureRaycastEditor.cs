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
				EditorGUILayout.HelpBox(HelpBox.ComponentError ("Foundation Raycast"), MessageType.Error);
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