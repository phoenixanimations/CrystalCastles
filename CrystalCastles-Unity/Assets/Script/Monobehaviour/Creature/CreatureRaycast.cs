using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent (typeof(FoundationRaycast))]
	public class CreatureRaycast : MonoBehaviour
	{
		[SerializeField]
		/// <summary>
		/// This grabs all the FoundationRaycast.cs methods essential for any raycast 
		/// as it holds both the variables and the main methods.
		/// This variable is affected by the editor reflection.
		/// </summary>
		private FoundationRaycast foundationRaycast;
//		public void exampleMethod ()
//		{
//			foundationRaycast.SearchForCollider(VectorMove.Down);
//		}
	}
}