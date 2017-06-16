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
		private CreatureRaycast serializedCreatureRaycast;
		public CreatureRaycast creatureRaycast
		{
			get 
			{
				return serializedCreatureRaycast;
			}

			private set 
			{
				serializedCreatureRaycast = value;
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