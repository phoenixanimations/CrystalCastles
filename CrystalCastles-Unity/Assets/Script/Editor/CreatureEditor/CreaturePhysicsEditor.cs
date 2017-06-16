using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(CreaturePhysics))]
	public class CreaturePhysicsEditor : Editor
	{
		private void Initialize ()
		{
			
		}

		public override void OnInspectorGUI ()
		{
			base.OnInspectorGUI ();
//			DisplayCreatureRaycastError();
		}

		/// <summary>
		/// Checks for two things, one if the CreatureRaycast is equipped, and two if the variables are correct.
		/// </summary>
		/// Jesus clean up this code.

		protected void DisplayCreatureRaycastError ()
		{
			
//			if ()
		}
//		protected void DisplayCreatureRaycastError ()
//		{
//			if ((CreatureRaycast)creaturePhysics.GetMemberValue("serializedCreatureRaycast") == null) 
//			{
//				EditorGUILayout.HelpBox ("CreatureRaycast is not connected, this will cause errors if you attack, or move. Click the button to avoid errors", MessageType.Error);
//				if (GUILayout.Button ("Set CreatureRaycast", GUILayout.Height (14f), GUILayout.Width (132f))) 
//				{
//					creaturePhysics.SetMemberValue("serializedCreatureRaycast", creaturePhysics.GetComponent<CreatureRaycast> ());
//				}
//			} 
//			else 
//			{
//				CircleCollider2D circleCollider2D = creaturePhysics.GetComponent<CircleCollider2D>();
//				float x = (float)creaturePhysics.creatureRaycast.GetMemberValue ("x");
//				float y = (float)creaturePhysics.creatureRaycast.GetMemberValue ("y");
//				if (creaturePhysics.creatureRaycast.length != 5.5f || x != circleCollider2D.offset.x || y != circleCollider2D.offset.y) 
//				{
//					EditorGUILayout.HelpBox ("CreatureRaycast is not exactly\nx = " +
//					circleCollider2D.offset.x + "\ny = " + circleCollider2D.offset.y +
//					"\nlength = 5.5f\nThis will mess up any movement, physics or attack code. Click the button to avoid errors.", MessageType.Warning);
//
//					if (GUILayout.Button ("Set CreatureRaycast", GUILayout.Height (14f), GUILayout.Width (132f))) 
//					{
//						creaturePhysics.creatureRaycast.SetMemberValue ("x", circleCollider2D.offset.x);
//						creaturePhysics.creatureRaycast.SetMemberValue ("y", circleCollider2D.offset.y);
//						creaturePhysics.creatureRaycast.SetMemberValue ("serializeLength", 5.5f);
//					}
//				}
//			}
//		}
	}
}
