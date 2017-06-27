using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrystalCastles;

namespace CrystalCastlesDebug
{
	public class VectorDebug
	{
		/// <summary>
		/// Converts the Crystal Castles engine's VectorMove Up, Down, Left, Right, to string.
		/// </summary>
		/// <returns>Returns Up, Down, Left, Right</returns>
		/// <param name="vectorToConvert">Insert a VectureCreature variable.</param>
		/// Note: This isn't a switch statement as vectors aren't supported by switch statements.
		public static string VectorMoveToText (Vector2 vectorToConvert)
		{
			string vectorString = "Not a VectorMove Vector.";
			if (vectorToConvert == VectorMove.up)
				vectorString =  "Up";
			if (vectorToConvert == VectorMove.down)
				vectorString =  "Down";
			if (vectorToConvert == VectorMove.left)
				vectorString =  "Left";
			if (vectorToConvert == VectorMove.right)
				vectorString =  "Right";
			return vectorString;
		}
	}
}