using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	/// Have a custom editor class that explains what each variables does and why they're on or off. 
	public class UnityDefault : MonoBehaviour
	{
		/// <summary>
		/// This should be access through reflection? 
		/// </summary>
		public readonly bool queriesStartInColliders = false;
		void Start ()
		{
			Physics2D.queriesStartInColliders = queriesStartInColliders;
		}
	}
}
