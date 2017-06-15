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

			creature.height = EditorGUILayout.FloatField ("Height", creature.height);
			DisplayErrorHeight ();

			creature.spriteRenderer = (SpriteRenderer)EditorGUILayout.ObjectField ("Sprite Renderer", creature.spriteRenderer, typeof(SpriteRenderer), false);
			DisplayErrorSpriteRenderer ();
			DisplayErrorCircleCollider2D ();
		}
	}
}