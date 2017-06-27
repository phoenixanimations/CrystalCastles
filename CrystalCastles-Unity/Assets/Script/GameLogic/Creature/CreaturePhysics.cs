using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent (typeof(FoundationPhysics))]
	[RequireComponent (typeof(CreatureRaycast))]
	[RequireComponent (typeof (Creature))]
	public class CreaturePhysics : MonoBehaviour, IUseInStart
	{
		/// <summary>
		/// This grabs the FoundationPhysics component a core feature of CreaturePhysics.
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private FoundationPhysics foundationPhysics;

		/// <summary>
		/// This grabs the FoundationPhysics component a core feature in CreaturePhysics.
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private CreatureRaycast creatureRaycast;

		/// <summary>
		/// Grabs the data of the overall Character Sheet, to handle any kind of gameobject.
		/// Game Logic includes searching for creatures that a higher than 3, or something.
		/// This variable works as a pointer, Creature.cs's characterSheet being the original
		/// reference.
		/// </summary>
		private CharacterSheet characterSheet;

		public void UseInStart ()
		{
			// Only grayed out to avoid a warning ungray out when you start working on this file.
//			characterSheet = GetComponent <Creature> ().characterSheet;
		}
	}
}