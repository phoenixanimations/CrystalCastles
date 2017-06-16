using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	public class CreatureRaycast : MonoBehaviour
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
		private float serializeLength;
		public float length 
		{ 
			get
			{
				return serializeLength;
			}

			private set 
			{
				serializeLength = value;
			}
		}

		/// <summary>
		/// This should be used for all raycasts that the Creature class makes.
		/// </summary>
		/// <returns>The creature position, plus the creatureRaycast.x, creatureRaycast.y</returns>
		public Vector2 DefaultPosition ()
		{
			return new Vector2 (transform.position.x + x, transform.position.y + y);
		}

		/// <summary>
		/// A wrapper function to avoid having to remember the confusing Direction * Length.
		/// </summary>
		/// <param name="Position">The position you want the ray to be cast.</param>
		/// <param name="Direction">The Direction of the ray.</param>
		/// <param name="Length">The length (can't be infinity).</param>
		protected void DebugDrawRay (Vector2 Position, Vector2 Direction, float Length)
		{
			Debug.DrawRay(Position,Direction * Length,Color.red);
		}
	}
}