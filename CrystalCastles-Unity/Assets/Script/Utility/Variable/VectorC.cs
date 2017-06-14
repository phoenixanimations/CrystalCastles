using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles
{
	/// <summary>
	/// Use this class VectorC (Crystal Castles) to grab the numbers for the Crystal Castles grid system.
	/// </summary>
	public class VectorC
	{
		/// <summary>
		/// Short hand for writing Vector2 (2.9f, 2.2f).
		/// </summary>
		public static readonly Vector2 Up = new Vector2 (2.9f, 2.2f);

		/// <summary>
		/// Short hand for writing Vector2 (-2.9f, -2.2f).
		/// </summary>
		public static readonly Vector2 Down = new Vector2 (-2.9f, -2.2f);

		/// <summary>
		/// Short hand for writing Vector2 (-5.2f, 0f).
		/// </summary>
		public static readonly Vector2 Left = new Vector2 (-5.2f, 0f);

		/// <summary>
		/// Short hand for writing Vector2 (5.2f, 0f);
		/// </summary>
		public static readonly Vector2 Right = new Vector2 (5.2f, 0f);	
	}
}