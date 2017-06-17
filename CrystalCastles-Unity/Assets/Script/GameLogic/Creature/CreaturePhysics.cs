using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	[RequireComponent (typeof(FoundationPhysics))]
	[RequireComponent (typeof(CreatureRaycast))]
	public class CreaturePhysics : MonoBehaviour 
	{
		/// <summary>
		/// This grabs the FoundationPhysics component a core feature of CreaturePhysics.
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private FoundationPhysics foundationPhysics;

		/// <summary>
		/// This grabs the FoundationPhysics component a core feature in CreaturePhysics.
		/// This variable is affected by the editor reflection.
		/// </summary>
		[SerializeField]
		private CreatureRaycast creatureRaycast;
	}
}