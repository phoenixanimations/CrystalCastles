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

		public override void OnInspectorGUI ()
		{
			creature = (Creature)target;
			creature.player = EditorGUILayout.Toggle ("Player", creature.player);

			EditorGUILayout.ObjectField ("Character Sheet", creature.characterSheet, typeof(CharacterSheet), false);
			EditorGUILayout.ObjectField ("Modifier Sheet", creature.modifierSheet, typeof(CharacterSheet), false);
			EditorGUILayout.ObjectField ("Sprite Renderer", creature.spriteRenderer, typeof(SpriteRenderer), false);
			EditorGUILayout.ObjectField ("Creature Raycast", creature.creaturePhysics, typeof(CreaturePhysics), false);
			EditorGUILayout.ObjectField ("Creature Physics", creature.creaturePhysics, typeof(CreaturePhysics), false);

			serializedObject.ApplyModifiedProperties();
		}
	}
}