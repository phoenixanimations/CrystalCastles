using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using CrystalCastlesDebug;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(Creature))]
	public class CreatureEditor : Editor
	{
		private Creature creature;

		/// <summary>
		/// Checks to make sure that creature front isn't {0, 0, 0}.
		/// </summary>
		protected void DisplayFrontError ()
		{
			if (creature.front == Vector2.zero)
			{
				EditorGUILayout.HelpBox("Front = {0, 0}, this will cause glitches. Click the button to avoid glitches", MessageType.Error);
				if (GUILayout.Button("Set Front", GUILayout.Height(14f), GUILayout.Width(70f)))
				{
					creature.front = VectorMove.Right;
				}
			}
		}

		public override void OnInspectorGUI ()
		{
			creature = (Creature)target;
			creature.player = EditorGUILayout.Toggle ("Player", creature.player);
			EditorGUILayout.BeginHorizontal();
			EditorGUILayout.LabelField("Creature Direction: ", GUILayout.Width (113f));
			EditorGUILayout.LabelField(VectorDebug.VectorCreatureToText(creature.front));
			EditorGUILayout.EndHorizontal();
			DisplayFrontError ();

			creature.creatureHeight = EditorGUILayout.FloatField ("Creature Height", creature.creatureHeight);
		
			EditorGUILayout.ObjectField ("Sprite Renderer", creature.spriteRenderer, typeof(SpriteRenderer), false);
			EditorGUILayout.ObjectField ("Creature Raycast", creature.creaturePhysics, typeof(CreaturePhysics), false);
			EditorGUILayout.ObjectField ("Creature Physics", creature.creaturePhysics, typeof(CreaturePhysics), false);

			serializedObject.ApplyModifiedProperties();
		}
	}
}