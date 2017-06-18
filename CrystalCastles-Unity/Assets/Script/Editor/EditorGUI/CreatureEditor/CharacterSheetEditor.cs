using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor(typeof(CharacterSheet))]
	public class CharacterSheetEditor : Editor
	{
		private CharacterSheet characterSheet;
		/// <summary>
		/// Used for making choosing a front direction more ui friendly.
		/// </summary>
		private enum direction
		{
			up, right, down, left
		}
		/// <summary>
		/// See direction.
		/// </summary>
		private direction selectDirection;
		/// <summary>
		/// The VectorMove two one of the enum directions.
		/// </summary>
		private void EnumGetFront ()
		{
			if (characterSheet.front == VectorMove.Up)
				selectDirection = direction.up;
			if (characterSheet.front == VectorMove.Right)
				selectDirection = direction.right;
			if (characterSheet.front == VectorMove.Down)
				selectDirection = direction.down;
			if (characterSheet.front == VectorMove.Left)
				selectDirection = direction.left;
		}
		/// <summary>
		/// Sets the characterSheet.Front two Up, Down, Left, or Right.
		/// </summary>
		private void EnumSetFront ()
		{
			switch (selectDirection) 
			{
			case direction.up:
				characterSheet.front = VectorMove.Up;
				break;
			case direction.right:
				characterSheet.front = VectorMove.Right;
				break;
			case direction.down:
				characterSheet.front = VectorMove.Down;
				break;
			case direction.left:
				characterSheet.front = VectorMove.Left;
				break;
			default:
				Debug.LogError("Some how there was more than four directions");
				break;
			}
		}

		public override void OnInspectorGUI ()
		{
			characterSheet = (CharacterSheet)target;
			characterSheet.toggleMove = EditorGUILayout.Toggle("Toggle Move", characterSheet.toggleMove);
			EnumGetFront();
			selectDirection = (direction)EditorGUILayout.EnumPopup("Front Direction ", selectDirection);
			EnumSetFront();
			characterSheet.creatureHeight = EditorGUILayout.FloatField("Creature Height", characterSheet.creatureHeight);
			characterSheet.worldHeight = EditorGUILayout.FloatField("World Height", characterSheet.worldHeight);
		}
	}
}