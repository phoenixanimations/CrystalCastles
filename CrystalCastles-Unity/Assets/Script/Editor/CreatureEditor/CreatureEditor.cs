using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(Creature))]
	public class CreatureEditor : CreatureErrorEditor
	{
		public override void OnInspectorGUI ()
		{
			Initialize();
			creature.player = EditorGUILayout.Toggle ("Player", creature.player);

			creature.creatureHeight = EditorGUILayout.FloatField ("Creature Height", creature.creatureHeight);
			DisplayErrorCreatureHeight ();

			EditorGUILayout.ObjectField ("Sprite Renderer", creature.spriteRenderer, typeof(SpriteRenderer), false);
			DisplayErrorSpriteRenderer ();

			EditorGUILayout.ObjectField ("Creature Raycast", creature.creatureRaycast, typeof(CreatureRaycast), false);
			DisplayCreatureRaycastError ();

			DisplayErrorCircleCollider2D ();
			serializedObject.ApplyModifiedProperties();
		}
	}
}