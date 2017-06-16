using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(CreaturePhysics))]
	public class CreaturePhysicsEditor : Editor
	{
		private CircleCollider2D circleCollider2D;
		private CreaturePhysics creaturePhysics;

		public override void OnInspectorGUI ()
		{
			creaturePhysics = (CreaturePhysics)target;
			EditorGUILayout.ObjectField("Creature Raycast", creaturePhysics.creatureRaycast, typeof(CreatureRaycast), false);
			RunOnlyOnce();
			DisplayCreaturePhysicsError();
			DisplayCreatureRaycastError();
		}

		/// <summary>
		/// Meant to be only run once.
		/// </summary>
		private bool turnMeOn = true;
		/// <summary>
		/// Couldn't figure out an elegant way to have it so getcompenent is only used once. 
		/// So I came up with a switch so it can grab the reference and then move on.
		/// </summary>
		private void RunOnlyOnce ()
		{
			if (turnMeOn)
				circleCollider2D = creaturePhysics.GetComponent<CircleCollider2D>();
			turnMeOn = false;
		}

		/// <summary>
		/// Displays an error if you don't have the component attached to the physics.
		/// </summary>
		private void DisplayCreaturePhysicsError ()
		{
			if (creaturePhysics.creatureRaycast == null)
			{
				EditorGUILayout.HelpBox("CreatureRaycast is not assigned. This will cause errors if you attack, or move. Click the button to avoid errors.", MessageType.Error);
				if (GUILayout.Button ("Set CreatureRaycast", GUILayout.Height (14f), GUILayout.Width (132f)))
				{
					creaturePhysics.SetMemberValue("serializeCreatureRaycast", creaturePhysics.GetComponent<CreatureRaycast> ());
				}
			}
		}

		/// <summary>
		/// This displays the button that sets the values for CreatureRaycast.
		/// </summary>
		private void DisplayCreatureRaycastErrorButton ()
		{
			if (GUILayout.Button ("Set CreatureRaycast", GUILayout.Height (14f), GUILayout.Width (132f))) 
			{
				creaturePhysics.creatureRaycast.SetMemberValue ("x", circleCollider2D.offset.x);
				creaturePhysics.creatureRaycast.SetMemberValue ("y", circleCollider2D.offset.y);
				creaturePhysics.creatureRaycast.SetMemberValue ("serializeLength", 5.5f);
			}
		}

		/// <summary>
		/// It might be argued that this is better for the the CreatureRaycast but hear me out. CreatureRaycast might not 
		/// want exact coordinates for whatever reason but CreaturePhysics can't function without the correct coordinates. 
		/// </summary>
		private void DisplayCreatureRaycastError ()
		{
			if (creaturePhysics.creatureRaycast != null)
			{
				float xRaycast = (float)creaturePhysics.creatureRaycast.GetMemberValue("x");
				float yRaycast = (float)creaturePhysics.creatureRaycast.GetMemberValue("y");
				float lengthRaycast = creaturePhysics.creatureRaycast.length;
				float xCircleCollider = circleCollider2D.offset.x;
				float yCircleCollider = circleCollider2D.offset.y;
				if (xRaycast != xCircleCollider || yRaycast != yCircleCollider || lengthRaycast != 5.5f)
				{
					EditorGUILayout.HelpBox ("CreatureRaycast is not exactly\nx = " +
					circleCollider2D.offset.x + "\ny = " + circleCollider2D.offset.y +
					"\nlength = 5.5f\nThis will mess up any movement, physics or attack code. Click the button to avoid errors.", MessageType.Warning);
					DisplayCreatureRaycastErrorButton();
				}
			}
		}
	}
}
