using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	/// <summary>
	/// All the starter classes, like CreaturePhysics/Raycast.cs get data from this class.
	/// </summary>
	/// Have the Bonus sheet be another character sheet and just call it bonus sheet. Use 
	/// classes to your advantage. 
	public class CharacterSheet : ScriptableObject
	{
		/// <summary>
		/// Determines whether the player can move. Mostly the physics engine/movement touches this. 
		/// But attacks can stop movement as well.
		/// </summary>
		public bool allowMovement;

		/// <summary>
		/// This determines the direction in which the player is facing.
		/// </summary>
		/// This is not in the CreatureMovement.cs or other files as multiple
		/// files effect (attack, physics, general input, etc). 
		public Vector2 front;

		/// <summary>
		/// This is the height of the creature.
		/// </summary>
		/// Height will not move to any file because it is used in both Physics, and Attack.
		/// This should not have a public set.
		public float creatureHeight;

		/// <summary>
		/// This represents the height the creature is in, in the world. 
		/// If the creature is standing on a cube with the height of 4.9 and the creature themselves has a height of
		/// 2.3 the worldHeight would be 7.2. The height is used in the Sort.SortLayer(List<Creature>) and
		/// in the attack code. Height is also checked for jumping.
		/// </summary>
		/// Height will not move to any file because it is used in both Physics, and Attack.
		public float worldHeight;
	}
}
