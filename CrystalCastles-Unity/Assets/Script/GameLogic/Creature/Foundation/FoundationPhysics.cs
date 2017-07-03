using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent(typeof(FoundationRaycast))]
	public class FoundationPhysics : FoundationMovement, IMove
	{
		[SerializeField]
		/// <summary>
		/// This grabs the FoundationRaycast.cs class and the methods as they are heavily used in the physics code.
		/// This variable is affected by the editor reflection.
		/// </summary>
		private FoundationRaycast foundationRaycast;

		/// <summary>
		/// Move in a specific direction, this should always be used with VectorMove.
		/// </summary>
		/// <param name="direction">The direction to move.</param>
		public void Move (Vector2 direction)
		{
			RaycastHit2D hit = foundationRaycast.SearchForCollider(direction);
			if (hit.collider == null)
			{
				NoClip (direction);
			}
		}	
	}
}
