using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	public class Transparent : MonoBehaviour
	{
		public float transparency;
		private SpriteRenderer spriteRenderer;

		void Start ()
		{
			spriteRenderer = this.GetComponent <SpriteRenderer> ();
			if (transparency == 0) {
				transparency = 1f;
			} else {
				transparency = transparency / 100f;
				spriteRenderer.color = new Color (1f, 1f, 1f, transparency);
			}
		}
	}
}