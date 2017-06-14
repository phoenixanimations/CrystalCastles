using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	/// <summary>
	/// The main purpose of this class is the Grab and Sort Layer button. 
	/// </summary>
	[CustomEditor(typeof(GameManager))]
	public class GameManagerEditor : Editor
	{
		/// <summary>
		/// This displays the Creature List variable. The reason this is a Serialized Property is because Unity does 
		/// not easily support List classes in their Editor GUI functions.
		/// </summary>
		private GameManager gameManager;
		private SerializedProperty creatureList;

		public void OnEnable ()
		{
			creatureList = serializedObject.FindProperty("creatureList");
		}

		public override void OnInspectorGUI ()
		{
			gameManager = (GameManager)target;
			EditorGUILayout.PropertyField(creatureList, true);
			grabAndSortCreatureLayer();
		}

		/// <summary>
		/// Grabs and sorts all the creatures in the scene using SpriteRenderer.OrderInLayer(int number)
		/// and Sort.SortLayer(List <Creature> creature).
		/// </summary>
		private void grabAndSortCreatureLayer ()
		{
			if (GUILayout.Button("Sort Creature's Layers", GUILayout.Height(14f), GUILayout.Width(132f))) 
			{
				grabMultipleCreature();
			}
		}

		/// <summary>
		/// I think this is a dangerious function. A couple things I don't like is I can no longer
		/// Manipulate lists by hand (not sure if this is intended or not). Unity doesn't show the list 
		/// in its reordered state even though the code reorders them.
		/// </summary>
		/// I don't know how I feel about modifying list data by passing it through parameters.
		/// I don't understand exactly how pointers/references work when it's a extension verses 
		/// a normal method. Also Unity takes about 3 seconds in order for the code to register 
		/// which is a little off putting.
		private void grabMultipleCreature ()
		{
			gameManager.creatureList.Clear();
			var creatureCollider = Physics2D.OverlapCircleAll (gameManager.transform.position, 200f);
			if (creatureCollider.Length > 0) 
			{
				gameManager.creatureList = creatureCollider.Select (c => c.gameObject.GetComponent<Creature> ())
											  			   .OrderByDescending (c => c.player)
											 			   .ToList ();
				gameManager.creatureList.Layer();
			}
		}
	}
}
