using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent (typeof(FoundationPhysics))]
	[RequireComponent (typeof(CreatureRaycast))]
	public class CreaturePhysics : CreaturePointerCharacterSheet, IMove
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
		/// Move in a specific direction, this should always be used with VectorMove.
		/// </summary>
		/// <param name="direction">The direction to move.</param>
		public void Move (Vector2 direction)
		{
			foundationPhysics.Move (direction);
		}
	}
}