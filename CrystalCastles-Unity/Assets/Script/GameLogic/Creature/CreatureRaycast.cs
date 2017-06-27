using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent (typeof(FoundationRaycast))]
	public class CreatureRaycast : CreaturePointerCharacterSheet
	{
		/// <summary>
		/// This grabs all the FoundationRaycast.cs methods essential for any raycast 
		/// as it holds both the variables and the main methods.
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private FoundationRaycast foundationRaycast;
	}
}