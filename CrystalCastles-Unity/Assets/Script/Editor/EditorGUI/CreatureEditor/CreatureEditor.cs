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
		/// This is a lazy implementation of the object checker, and just checks if everything is equipped. 
		/// </summary>
		private void ObjectError ()
		{
			if (creature.characterSheet == null || creature.modifierSheet == null || creature.spriteRenderer == null || creature.creatureRaycast == null || creature.creaturePhysics == null)
			{
				EditorGUILayout.HelpBox ("Not all components are attached to the variables. This will cause errors and Creature will not work properly with the Crystal Castle engine.", MessageType.Error);
			}
		}
			
		public override void OnInspectorGUI ()
		{
			creature = (Creature)target;
			creature.player = EditorGUILayout.Toggle ("Player", creature.player);

			creature.characterSheet = (CharacterSheet)EditorGUILayout.ObjectField ("Character Sheet", creature.characterSheet, typeof(CharacterSheet), true);
			creature.modifierSheet = (CharacterSheet)EditorGUILayout.ObjectField ("Modifier Sheet", creature.modifierSheet, typeof(CharacterSheet), true);
			creature.spriteRenderer = (SpriteRenderer)EditorGUILayout.ObjectField ("Sprite Renderer", creature.spriteRenderer, typeof(SpriteRenderer), true);
			creature.creatureRaycast = (CreatureRaycast)EditorGUILayout.ObjectField ("Creature Raycast", creature.creatureRaycast, typeof(CreatureRaycast), true);
			creature.creaturePhysics = (CreaturePhysics)EditorGUILayout.ObjectField ("Creature Physics", creature.creaturePhysics, typeof(CreaturePhysics), true);

			ObjectError();

			serializedObject.ApplyModifiedProperties();
		}
	}
}