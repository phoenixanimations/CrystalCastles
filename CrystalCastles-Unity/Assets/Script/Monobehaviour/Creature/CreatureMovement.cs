using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	public class CreatureMovement : MonoBehaviour
	{
		/// <summary>
		/// This should never be used unless debugging. Certain moves and objects
		/// will not respond in the correct way (such as noclipping through fire).
		/// </summary>
		/// <param name="direction">The direction you want to completely break the game.</param>
		public void NoClip (Vector2 direction)
		{
			transform.position = new Vector2 (transform.position.x + direction.x, transform.position.y + direction.y);
		}

		/// <summary>
		/// Teleport to a specified location. A dangerious function as you can teleport off grid.
		/// </summary>
		/// <param name="location">The location (make sure it's on the grid).</param>
		public void Teleport (Vector2 location)
		{
			transform.position = new Vector2 (location.x, location.y);
		}
	}
}