using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalCastles.CrystalDebug
{
	public class VectorDebug
	{
		/// <summary>
		/// Converts the Crystal Castles engine's VectorC Up, Down, Left, Right, to string.
		/// </summary>
		/// <returns>Returns Up, Down, Left, Right</returns>
		/// <param name="vectorToConvert">Crystal Castles VectorC to convert into a string.</param>
		/// Note: This isn't a switch statement as vectors aren't supported by switch statements.
		public static string VectorCToText (Vector2 vectorToConvert)
		{
			string vectorString = "Not a VectorC.";
			if (vectorToConvert == VectorC.Up)
				vectorString =  "Up";
			if (vectorToConvert == VectorC.Down)
				vectorString =  "Down";
			if (vectorToConvert == VectorC.Left)
				vectorString =  "Left";
			if (vectorToConvert == VectorC.Right)
				vectorString =  "Right";
			return vectorString;
		}
	}
}