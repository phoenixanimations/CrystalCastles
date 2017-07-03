using System.Collections;
using UnityEngine;

namespace CrystalCastles
{
	interface IMove
	{
		/// <summary>
		/// Move in a specific direction, this should always be used with VectorMove.
		/// </summary>
		/// <param name="direction">The direction to move.</param>
		void Move (Vector2 direction);
	}
}