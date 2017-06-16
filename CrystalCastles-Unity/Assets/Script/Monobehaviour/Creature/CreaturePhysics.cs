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
	}
}