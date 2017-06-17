using UnityEngine;
using UnityEditor;

namespace CrystalCastles.UnityEditor
{
	public class Create
	{
		[MenuItem ("Create/New Character Sheet")]
		public static void NewCharacterSheet ()
		{
			ScriptableObjectUtility.CreateAsset<CharacterSheet> ();
		}
	}
}