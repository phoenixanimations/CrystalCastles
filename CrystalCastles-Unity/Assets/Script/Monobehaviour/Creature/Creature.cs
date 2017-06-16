using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CrystalCastles
{
	/// <summary> 
	/// The Creature Class purpose right now is almost like a "god prefab". 
	/// I will try to break up this "god prefab" as best I can but as of right now
	/// it uses and relies on a bunch of classes. 
	/// </summary>
	[RequireComponent (typeof(SpriteRenderer))]
	[RequireComponent (typeof(CircleCollider2D))]
	[RequireComponent (typeof(CreatureRaycast))]
	[RequireComponent (typeof (CreaturePhysics))]
	public class Creature : MonoBehaviour
	{
		/// <summary>
		/// Player is used by two classes, GameManager and the input class.
		/// </summary>
		/// The GameManager uses the player bool to sort the true objects first. 
		/// The input class checks if player is true and then acts accordingly.
		/// The AI class checks if player is false. 
		public bool player;

		/// <summary>
		/// This determines the direction in which the player is facing.
		/// </summary>
		/// This is not in the CreatureMovement.cs or other files as multiple
		/// files effect (attack, physics, general input, etc). 
		public Vector2 front;

		/// <summary>
		/// Determines whether the player can move. Mostly the physics engine/movement touches this. 
		/// But attacks can stop movement as well.
		/// </summary>
		public bool allowMovement;

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

		/// <summary>
		/// The sprite renderer is required soley because of sort.SortLayer(List<Creature>). Perhaps there is 
		/// a way to make it so this isn't needed.
		/// </summary>
		/// spriteRenderer is assigned on scene to make it compatible with the GUI Editor 
		/// Game Manager button. This should not be able to be set.
		public SpriteRenderer spriteRenderer;

		/// <summary>
		/// This will handle the physics of the Crystal Castle engine.
		/// </summary>
		/// This should not have a public set.
		public CreaturePhysics creaturePhysics;
	}
}