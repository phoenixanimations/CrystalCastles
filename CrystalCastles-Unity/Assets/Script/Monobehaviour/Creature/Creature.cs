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
		/// The height is used in the Sort.SortLayer(List<Creature>) and
		/// in the attack code. Height is also checked for jumping. 
		/// </summary>
		public float height;

		/// <summary>
		/// The sprite renderer is required soley because of sort.SortLayer(List<Creature>). Perhaps there is 
		/// a way to make it so this isn't needed.
		/// </summary>
		/// spriteRenderer is assigned on scene to make it compatible with the GUI Editor 
		/// Game Manager button.
		public SpriteRenderer spriteRenderer;
	}
}