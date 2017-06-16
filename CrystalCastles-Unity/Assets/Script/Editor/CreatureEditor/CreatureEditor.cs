using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using CrystalCastlesDebug;

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

			EditorGUILayout.LabelField("Creature Direction: " + VectorDebug.VectorCreatureToText(creature.front));
			DisplayFrontError ();

			EditorGUILayout.ObjectField ("Sprite Renderer", creature.spriteRenderer, typeof(SpriteRenderer), false);
			DisplayErrorSpriteRenderer ();

			EditorGUILayout.ObjectField ("Creature Physics", creature.creaturePhysics, typeof(CreaturePhysics), false);
			DisplayCreaturePhysicsError();

			DisplayErrorCircleCollider2D ();
			serializedObject.ApplyModifiedProperties();
		}
	}
}