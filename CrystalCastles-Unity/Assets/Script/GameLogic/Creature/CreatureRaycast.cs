using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent (typeof(FoundationRaycast))]
	[RequireComponent (typeof (Creature))]
	public class CreatureRaycast : MonoBehaviour, IUseInStart
	{
		/// <summary>
		/// This grabs all the FoundationRaycast.cs methods essential for any raycast 
		/// as it holds both the variables and the main methods.
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private FoundationRaycast foundationRaycast;

		/// <summary>
		/// Grabs the data of the overall Character Sheet, to handle any kind of gameobject.
		/// Game Logic includes searching for creatures that a higher than 3, or something.
		/// This variable works as a pointer, Creature.cs's characterSheet being the original
		/// reference.
		/// </summary>
		private CharacterSheet characterSheet;

		public void UseInStart ()
		{
			// Only Grayed out to avoid the warning, ungray out when you start using this.
//			characterSheet = GetComponent <Creature> ().characterSheet;
		}
	}
}