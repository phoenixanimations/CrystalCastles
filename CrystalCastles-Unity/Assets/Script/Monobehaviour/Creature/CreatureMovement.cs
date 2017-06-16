using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	public class CreatureMovement : MonoBehaviour
	{
		public void Move (Vector2 direction)
		{
			transform.position = new Vector2 (transform.position.x + direction.x, transform.position.y + direction.y);
		}
	}
}