using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles.Mouse
{
	public class SelectGUIGarbage : MonoBehaviour
	{
		public string direction;
		public bool inner;
		void OnCollisionEnter2D (Collision2D other) 
		{
			if (inner)
			{
//				this.enabled = false;
			}
			
			switch (direction) 
			{
			case "Up":
				transform.parent.position += (Vector3)VectorC.Up;
				break;

			case "Right":
				transform.parent.position += (Vector3)VectorC.Right;
				break;

			case "Down":
				transform.parent.position += (Vector3)VectorC.Down;
				break;

			case "Left":
				transform.parent.position += (Vector3)VectorC.Left;
				break;
			default:
				Debug.Log("Take my eyes out and make it into soup.");
				break;
			}
		}
	}
}
