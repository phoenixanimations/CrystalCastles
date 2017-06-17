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
		public static string VectorCreatureToText (Vector2 vectorToConvert)
		{
			string vectorString = "Not a VectorMove Vector.";
			if (vectorToConvert == VectorMove.Up)
				vectorString =  "Up";
			if (vectorToConvert == VectorMove.Down)
				vectorString =  "Down";
			if (vectorToConvert == VectorMove.Left)
				vectorString =  "Left";
			if (vectorToConvert == VectorMove.Right)
				vectorString =  "Right";
			return vectorString;
		}
	}
}