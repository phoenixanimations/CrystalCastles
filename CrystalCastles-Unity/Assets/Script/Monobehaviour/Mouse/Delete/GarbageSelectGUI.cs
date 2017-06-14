using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles.Mouse
{
	public class GarbageSelectGUI : MonoBehaviour
	{
		public Transform center;
		public string direction;
//		private float offset = .5f;
		void OnCollisionEnter2D (Collision2D other) 
		{
			switch (direction) 
			{
			case "Up":
				transform.parent.position += (Vector3)VectorC.Up;
				other.transform.position = new Vector3 (center.position.x, center.position.y);
				break;
			case "Right":
				transform.parent.position += (Vector3)VectorC.Right;
				other.transform.position = new Vector3 (center.position.x, center.position.y);
				break;
			case "Down":
				transform.parent.position += (Vector3)VectorC.Down;
				other.transform.position = new Vector3 (center.position.x, center.position.y);
				break;
			case "Left":
				transform.parent.position += (Vector3)VectorC.Left;
				other.transform.position = new Vector3 (center.position.x, center.position.y);
				break;

			case "UpLeft":
				transform.parent.position += (Vector3)(VectorC.Up + VectorC.Left);
				other.transform.position = new Vector3 (center.position.x, center.position.y);
				break;
			case "UpRight":
				transform.parent.position += (Vector3)(VectorC.Up + VectorC.Right);
				other.transform.position = new Vector3 (center.position.x, center.position.y);
				break;
			case "DownRight":
				transform.parent.position += (Vector3)(VectorC.Down + VectorC.Right);
				other.transform.position = new Vector3 (center.position.x, center.position.y);
				break;
			case "DownLeft":
				transform.parent.position += (Vector3)(VectorC.Down + VectorC.Left);
				other.transform.position = new Vector3 (center.position.x, center.position.y);
				break;
			default:
				Debug.Log("Take my eyes out and make it into soup.");
				break;
			}
		}
	}
}
