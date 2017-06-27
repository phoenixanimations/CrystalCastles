using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent (typeof (Creature))]
	public class CreaturePointerCharacterSheet : MonoBehaviour, IUseInStart
	{
		/// <summary>
		/// Grabs the data of the overall Character Sheet, to handle any kind of gameobject.
		/// Game Logic includes searching for creatures that a higher than 3, or something.
		/// This variable works as a pointer, Creature.cs's characterSheet being the original
		/// reference.
		/// </summary>
		protected CharacterSheet characterSheet;

		public void UseInStart ()
		{
			characterSheet = GetComponent <Creature> ().characterSheet;
		}
	}
}
