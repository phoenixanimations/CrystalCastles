using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	public sealed class FoundationRaycast : MonoBehaviour
	{
		/// <summary>
		/// The x variable has to be serialized, in order to modify them in the
		/// editor. This is because Unity saves your objects before you hit
		/// the play button and if they're not serialized they will reset to 0. 
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private float x;

		/// <summary>
		/// See x.
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private float y;

		/// <summary>
		/// See x. 
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private float serializeDistance;
		public float distance 
		{ 
			get
			{
				return serializeDistance;
			}

			private set 
			{
				serializeDistance = value;
			}
		}

		/// <summary>
		/// This adds the coords for x, y to the transform.position.
		/// </summary>
		/// <returns>Vector2 (foundationRaycast.x + transform.position.x, foundationRaycast.y transform.position.y)</returns>
		public Vector2 DefaultPosition ()
		{
			return new Vector2 (transform.position.x + x, transform.position.y + y);
		}

		/// <summary>
		/// A wrapper function of DrawRay to avoid having to remember the confusing Direction * Length.
		/// </summary>
		/// <param name="Position">The position you want the ray to be cast.</param>
		/// <param name="Direction">The Direction of the ray.</param>
		/// <param name="Length">The length (can't be infinity).</param>
		public void DebugDrawRay (Vector2 Position, Vector2 Direction, float Length)
		{
			Debug.DrawRay(Position,Direction * Length,Color.red);
		}

		/// <summary>
		/// This is a direct wrapper of the Physics2D.Raycast method. This only because it is subject to change.
		/// The end result shouldn't be a 1:1 wrapper.
		/// </summary>
		/// <returns>RaycastHit2D, or null if nothing was hit.</returns>
		/// <param name="position">Enter where the coordinates start.</param>
		/// <param name="direction">Enter which direction it should go.</param>
		/// <param name="distance">Enter how far.</param>
		/// If it ends up being a direct wrapper simply replace the two public SearchForCollider returns with Physics.Raycast.
		private RaycastHit2D SearchForCollider (Vector2 position, Vector2 direction, float distance)
		{
			RaycastHit2D raycastHit2D = Physics2D.Raycast(position, direction, distance);
			return raycastHit2D;
		}

		/// <summary>
		/// Searches for collider by length x lengthTimesAmount.
		/// </summary>
		/// <returns>RaycastHit2D, or null if nothing was hit.</returns>
		/// <param name="direction">The direction to raycast.</param>
		/// <param name="lengthTimesAmout">The number you input will then be multiplied by the foundationRaycast.length.</param>
		public RaycastHit2D SearchForCollider (Vector2 direction, float lengthTimesAmout)
		{
			return SearchForCollider (DefaultPosition(), direction, distance * lengthTimesAmout);
		}

		/// <summary>
		/// A wrapper that just searches for a collider in a direction.
		/// </summary>
		/// <returns>RaycastHit2D, or null if nothing was hit.</returns>
		/// <param name="direction">The direction to cast the ray.</param>
		public RaycastHit2D SearchForCollider (Vector2 direction)
		{
			return SearchForCollider (DefaultPosition(), direction, distance);
		}	
	}
}
