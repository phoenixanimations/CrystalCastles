using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent(typeof(CircleCollider2D))]
	[RequireComponent(typeof(CreatureRaycast))]
	public class CreaturePhysics : CreatureMovement 
	{
		[SerializeField]
		/// <summary>
		/// This grabs the raycast code and their methods as they are heavily used in the physics code.
		/// This variable is affected by the editor reflection.
		/// </summary>
		private CreatureRaycast serializeCreatureRaycast;
		public CreatureRaycast creatureRaycast
		{
			get 
			{
				return serializeCreatureRaycast;
			}

			private set 
			{
				serializeCreatureRaycast = value;
			}
		}

		public void Move (Vector2 direction)
		{
			RaycastHit2D hit = creatureRaycast.SearchForCreature(direction);
			if (hit.collider == null)
			{
				NoClip (direction);
			}
		}
	}
}