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
	/// Creature acts as the final functions to be used as the engine.
	/// To avoid any kind of reliabilty between components the creature should have final say. 
	/// It's the only object that knows about everything.
	[RequireComponent (typeof(SpriteRenderer))]
	[RequireComponent (typeof(CircleCollider2D))]
	[RequireComponent (typeof(CreatureRaycast))]
	[RequireComponent (typeof (CreaturePhysics))]
	public class Creature : MonoBehaviour, IUseInStart
	{
		/// <summary>
		/// Player is used by two classes, GameManager and the input class.
		/// </summary>
		/// The GameManager uses the player bool to sort the true objects first. 
		/// The input class checks if player is true and then acts accordingly.
		/// The AI class checks if player is false. 
		public bool player;

		/// <summary>
		/// The container for any game logic/stats.
		/// </summary>
		/// This should not have a public set.
		public CharacterSheet characterSheet;

		/// <summary>
		/// If you want a temporary modifier to any stat, this is what you use.
		/// </summary>
		/// This should not have a public set.
		public CharacterSheet modifierSheet;

		/// <summary>
		/// The sprite renderer is required soley because of sort.SortLayer(List<Creature>). Perhaps there is 
		/// a way to make it so this isn't needed.
		/// </summary>
		/// spriteRenderer is assigned on scene to make it compatible with the GUI Editor 
		/// Game Manager button. This should not have a public set.
		public SpriteRenderer spriteRenderer;

		/// <summary>
		/// This handles the raycasting for attack, move, physics etc.
		/// </summary>
		/// This should not have a public set.
		public CreatureRaycast creatureRaycast;

		/// <summary>
		/// This will handle the physics of the Crystal Castle engine.
		/// </summary>
		/// This should not have a public set.
		public CreaturePhysics creaturePhysics;

		/// <summary>
		/// This function should be used in the GameManager's start function.
		/// This function is only meant to run once. Much like a regular class constructor.
		/// </summary>
		public void UseInStart () 
		{
			/// Fixes the glitch of having the objects grab from one reference and creates a new reference on runtime.
			characterSheet = ScriptableObject.Instantiate <CharacterSheet> (characterSheet);
			modifierSheet = ScriptableObject.Instantiate <CharacterSheet> (modifierSheet);

			/// These are called after for clarity sake. It actually doesn't matter since these assign a variable that just points to
			/// Creature.cs CharacterSheet.
			creatureRaycast.UseInStart ();
			creaturePhysics.UseInStart ();
		}
	}
}