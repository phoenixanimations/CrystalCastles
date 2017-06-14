using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using CrystalCastles;

namespace CrystalCastles.UnityEditor
{
	[CustomEditor (typeof(UnityDefault))]
	public class UnityDefaultEditor : Editor
	{
		private UnityDefault unityDefault;

		public override void OnInspectorGUI ()
		{
			unityDefault = (UnityDefault)target;
			EditorGUILayout.LabelField ("Queries Start In Colliders: " + unityDefault.queriesStartInColliders.ToString ());
		}
	}
}